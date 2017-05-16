namespace Machete.HL7
{
    using System;
    using System.Linq.Expressions;


    public abstract class HL7LayoutMap<TLayout, TSchema> :
        LayoutMap<TLayout, TSchema>
        where TSchema : HL7Entity
        where TLayout : HL7Layout
    {
        protected void Segment<T>(Expression<Func<TLayout, Segment<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TSchema
        {
        }

        protected void Segment<T>(Expression<Func<TLayout, SegmentList<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TSchema
        {
        }
    }
}