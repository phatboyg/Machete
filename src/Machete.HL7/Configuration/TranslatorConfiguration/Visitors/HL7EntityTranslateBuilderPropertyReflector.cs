namespace Machete.HL7.TranslatorConfiguration.Visitors
{
    using System.Linq;
    using System.Reflection;
    using Internals.Extensions;
    using Machete.TranslatorConfiguration.Visitors;


    public class HL7EntityTranslateBuilderPropertyReflector<TVisitor, TSchema> :
        EntityTranslateBuilderPropertyReflector<TVisitor, TSchema>
        where TVisitor : ITranslateBuilderPropertyVisitor<TSchema>
        where TSchema : Entity
    {
        public override void Property(TVisitor visitor, PropertyInfo property)
        {
            if (property.PropertyType.HasInterface(typeof(Segment<>)))
            {
                var valueType = property.PropertyType.GetClosingArguments(typeof(Segment<>)).Single();

                var methodType = typeof(TVisitor)
                    .GetMethod("Segment")
                    .MakeGenericMethod(valueType);

                CompileCallMethod(methodType)(visitor, property);
            }
            else if (property.PropertyType.HasInterface(typeof(SegmentList<>)))
            {
                var valueType = property.PropertyType.GetClosingArguments(typeof(SegmentList<>)).Single();

                var methodType = typeof(TVisitor)
                    .GetMethod("SegmentList")
                    .MakeGenericMethod(valueType);

                CompileCallMethod(methodType)(visitor, property);
            }
            else
            {
                base.Property(visitor, property);
            }
        }
    }
}