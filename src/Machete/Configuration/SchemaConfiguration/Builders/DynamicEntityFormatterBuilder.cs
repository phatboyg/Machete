namespace Machete.SchemaConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;
    using Internals.Extensions;
    using Slices.Providers;


    public class DynamicEntityFormatterBuilder<TEntity, TSchema> :
        IEntityFormatterBuilder<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly ISchemaBuilder<TSchema> _schemaBuilder;
        readonly IDictionary<int, IEntityPropertyFormatter<TEntity>> _sliceProviders;

        public DynamicEntityFormatterBuilder(ISchemaBuilder<TSchema> schemaBuilder)
        {
            _schemaBuilder = schemaBuilder;
            _sliceProviders = new Dictionary<int, IEntityPropertyFormatter<TEntity>>();

            Factory = formatters => new DynamicEntityFormatter<TEntity, TSchema>(formatters);
        }

        IEntityFormatter<T> IEntityFormatterBuilder<TEntity, TSchema>.GetEntityFormatter<T>()
        {
            return _schemaBuilder.GetEntityFormatter<T>();
        }

        public void Add(int position, IEntityPropertyFormatter<TEntity> formatter)
        {
            if (_sliceProviders.ContainsKey(position))
                throw new ArgumentException($"{TypeCache<TEntity>.ShortName}[{position}] already exists.");

            _sliceProviders.Add(position, formatter);
        }

        public EntityFormatterFactory<TEntity> Factory { private get; set; }

        public IEntityFormatter<TEntity> Build()
        {
            var lastPosition = _sliceProviders.Max(x => x.Key);
            List<IEntityPropertyFormatter<TEntity>> formatters = Enumerable.Range(0, lastPosition)
                .Select(index => _sliceProviders.ContainsKey(index) ? _sliceProviders[index] : new EmptyEntityPropertyFormatter<TEntity>())
                .ToList();

            if (Factory == null)
                throw new MacheteSchemaException($"The {TypeCache<TEntity>.ShortName} FormatterFactory was null");

            return Factory(formatters);
        }
    }
}