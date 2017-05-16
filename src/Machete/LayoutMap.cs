namespace Machete
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using StructureConfiguration;
    using StructureConfiguration.Specifications;
    using TemplateConfiguration;


    public abstract class LayoutMap<TLayout, TSchema> :
        ILayoutSpecification<TSchema>
        where TLayout : Layout
        where TSchema : Entity
    {
        protected LayoutSpecification<TLayout, TSchema> Specification { get; }

        protected LayoutMap()
        {
            Specification = new LayoutSpecification<TLayout, TSchema>();
        }

        protected void Entity<T>(Expression<Func<TLayout, Entity<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TSchema
        {
        }

        protected void Entity<T>(Expression<Func<TLayout, EntityList<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TSchema
        {
        }

        protected void Layout<T>(Expression<Func<TLayout, Layout<T>>> propertyExpression, int position, Action<IGroupConfigurator<T>> configure = null)
            where T : Layout
        {
        }

        protected void Layout<T>(Expression<Func<TLayout, LayoutList<T>>> propertyExpression, int position, Action<IGroupConfigurator<T>> configure = null)
            where T : Layout
        {
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return Specification.Validate();
        }

        public Type TemplateType => Specification.TemplateType;

        public IEnumerable<Type> GetReferencedLayoutTypes()
        {
            return Specification.GetReferencedLayoutTypes();
        }

        public void Apply(IStructureBuilder<TSchema> builder)
        {
            Specification.Apply(builder);
        }
    }
}