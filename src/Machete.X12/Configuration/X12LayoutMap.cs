namespace Machete.X12.Configuration
{
    using System;
    using System.Linq.Expressions;
    using Internals.Extensions;
    using Layouts;
    using Machete.SchemaConfiguration;
    using Machete.SchemaConfiguration.Specifications;


    public abstract class X12LayoutMap<TLayout, TSchema> :
        LayoutMap<TLayout, TSchema>
        where TSchema : X12Entity
        where TLayout : X12Layout
    {
        protected void Segment<T>(Expression<Func<TLayout, Segment<T>>> propertyExpression, int position, Action<IEntityLayoutConfigurator<TSchema, T>> configure = null)
            where T : TSchema, X12Segment
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityLayoutPropertySpecification<TLayout, TSchema, T, Segment<T>>(propertyInfo, position, x => new SegmentProperty<T>(x));

            configure?.Invoke(specification);

            Specification.Add(propertyInfo.Name, specification);
        }

        protected void Segment<T>(Expression<Func<TLayout, SegmentList<T>>> propertyExpression, int position, Action<IEntityLayoutConfigurator<TSchema, T>> configure = null)
            where T : TSchema, X12Segment
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityListLayoutPropertySpecification<TLayout, TSchema, T, SegmentList<T>>(propertyInfo, position, x => new SegmentListProperty<T>(x));

            configure?.Invoke(specification);

            Specification.Add(propertyInfo.Name, specification);
        }

        protected string Id
        {
            set => Specification.Id = value;
        }

        protected string Name
        {
            set => Specification.Name = value;
        }
    }
}