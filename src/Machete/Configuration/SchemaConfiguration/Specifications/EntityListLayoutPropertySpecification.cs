namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Layouts.LayoutProperties;


    public class EntityListLayoutPropertySpecification<TLayout, TSchema, TEntity, TProperty> :
        ILayoutPropertySpecification<TLayout, TSchema>,
        IEntityLayoutConfigurator<TSchema, TEntity>
        where TLayout : Layout
        where TSchema : Entity
        where TEntity : TSchema
        where TProperty : EntityList<TEntity>
    {
        readonly PropertyInfo _property;
        readonly Func<EntityList<TEntity>, TProperty> _propertyConverter;

        public EntityListLayoutPropertySpecification(PropertyInfo property, int position, Func<EntityList<TEntity>, TProperty> propertyConverter)
        {
            _property = property;
            Position = position;
            _propertyConverter = propertyConverter;
        }

        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public int Position { get; }

        public IEnumerable<Type> GetReferencedLayoutTypes()
        {
            yield break;
        }

        public IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield return typeof(TEntity);
        }

        public void Apply(ILayoutBuilder<TLayout, TSchema> builder)
        {
            var property = new EntityListLayoutProperty<TLayout, TSchema, TEntity, TProperty>(_property, Required, _propertyConverter, Condition);

            builder.Add(property);
        }

        public bool Required { get; set; }
        public EntityLayoutCondition<TSchema, TEntity> Condition { get; set; }
    }
}