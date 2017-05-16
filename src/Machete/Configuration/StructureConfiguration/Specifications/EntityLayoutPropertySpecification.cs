namespace Machete.StructureConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Internals.Extensions;


    public class EntityLayoutPropertySpecification<TLayout, TSchema, TEntity> :
        ILayoutPropertySpecification<TLayout, TSchema>
        where TLayout : Layout
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly ISchema<TSchema> _schema;
        readonly PropertyInfo _property;
        readonly int _position;

        public EntityLayoutPropertySpecification(ISchema<TSchema> schema, PropertyInfo property, int position)
        {
            _schema = schema;
            _property = property;
            _position = position;
        }

        public IEnumerable<ValidateResult> Validate()
        {
            IEntityFactory<TEntity> entityFactory;
            if (_schema.TryGetEntityFactory(out entityFactory) == false)
                yield return this.Error($"Entity not defined: {TypeCache<TEntity>.ShortName}", nameof(TEntity));
        }

        public IEnumerable<Type> GetReferencedLayoutTypes()
        {
            yield break;
        }

        public void Apply(ILayoutBuilder<TLayout, TSchema> builder)
        {
            var property = new EntityLayoutProperty<TLayout, TSchema, TEntity>(_property);

            builder.Add(property);
        }
    }
}