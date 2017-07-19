namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Layouts.LayoutProperties;


    /// <summary>
    /// Matches an entity in a layout
    /// </summary>
    /// <typeparam name="TLayout"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TProperty"></typeparam>
    public class EntityLayoutPropertySpecification<TLayout, TSchema, TEntity, TProperty> :
        ILayoutPropertySpecification<TLayout, TSchema>,
        IEntityConfigurator<TEntity>
        where TLayout : Layout
        where TSchema : Entity
        where TEntity : TSchema
        where TProperty : Entity<TEntity>
    {
        readonly PropertyInfo _property;
        readonly Func<Entity<TEntity>, TProperty> _propertyConverter;

        public EntityLayoutPropertySpecification(PropertyInfo property, int position, Func<Entity<TEntity>, TProperty> propertyConverter)
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
            var property = new EntityLayoutProperty<TLayout, TSchema, TEntity, TProperty>(builder.ImplementationType, _property, Required, _propertyConverter);

            builder.Add(property);
        }

        public bool Required { private get; set; }
    }
}