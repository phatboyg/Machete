namespace Machete.HL7
{
    using System;
    using System.Linq.Expressions;
    using Internals.Extensions;
    using Layouts;
    using Machete.SchemaConfiguration;
    using Machete.SchemaConfiguration.Specifications;


    public abstract class HL7LayoutMap<TLayout, TSchema> :
        LayoutMap<TLayout, TSchema>
        where TSchema : HL7Entity
        where TLayout : HL7Layout
    {
        protected void Segment<T>(Expression<Func<TLayout, Segment<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TSchema, HL7Segment
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityLayoutPropertySpecification<TLayout, TSchema, T, Segment<T>>(propertyInfo, position, x => new SegmentProperty<T>(x));

            configure?.Invoke(specification);

            Specification.Add(propertyInfo.Name, specification);
        }

        protected void Segment<T>(Expression<Func<TLayout, SegmentList<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TSchema, HL7Segment
        {
            var propertyInfo = propertyExpression.GetPropertyInfo();

            var specification = new EntityListLayoutPropertySpecification<TLayout, TSchema, T, SegmentList<T>>(propertyInfo, position, x => new SegmentListProperty<T>(x));

            configure?.Invoke(specification);

            Specification.Add(propertyInfo.Name, specification);
        }
    }
}