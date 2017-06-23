namespace Machete.SchemaConfiguration.Builders
{
    using System.Collections.Generic;
    using Entities;

    public class DynamicEntityFormatterBuilder<TEntity, TSchema> :
        IEntityFormatterBuilder<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly ISchemaBuilder<TSchema> _schemaBuilder;
        readonly IList<ITextSliceProvider<TEntity>> _sliceProviders;

        public DynamicEntityFormatterBuilder(ISchemaBuilder<TSchema> schemaBuilder)
        {
            _schemaBuilder = schemaBuilder;
            _sliceProviders = new List<ITextSliceProvider<TEntity>>();
        }

        IEntityFormatter<T> IEntityFormatterBuilder<TEntity, TSchema>.GetEntityFormatter<T>()
        {
            return _schemaBuilder.GetEntityFormatter<T>();
        }

        public void Add(ITextSliceProvider<TEntity> sliceProvider)
        {
            _sliceProviders.Add(sliceProvider);
        }

        public IEntityFormatter<TEntity> Build()
        {
            return new DynamicEntityFormatter<TEntity, TSchema>(_sliceProviders);
        }
    }
}