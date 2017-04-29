namespace Machete.HL7
{
    using System;
    using System.Linq.Expressions;


    public class HL7TemplateMap<TTemplate, TTemplateSchema> :
        TemplateMap<TTemplate, TTemplateSchema>
        where TTemplateSchema : HL7Entity
        where TTemplate : Template<TTemplateSchema>, TTemplateSchema
    {
        protected void Segment<T>(Expression<Func<TTemplate, Segment<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TTemplateSchema
        {
        }
        protected void Segments<T>(Expression<Func<TTemplate, SegmentList<T>>> propertyExpression, int position, Action<IEntityConfigurator<T>> configure = null)
            where T : TTemplateSchema
        {
        }
    }
}