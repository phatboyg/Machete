namespace Machete.HL7.TranslateConfiguration.Visitors
{
    using System.Linq;
    using System.Reflection;
    using Internals.Extensions;
    using Machete.TranslateConfiguration.Visitors;


    public class HL7EntityTranslateBuilderPropertyReflector<TVisitor, TResult, TInput, TSchema> :
        EntityTranslateBuilderPropertyReflector<TVisitor, TResult, TInput, TSchema>
        where TVisitor : ITranslateBuilderPropertyVisitor<TSchema>
        where TResult : TSchema
        where TInput : TSchema
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
            else if (property.PropertyType.HasInterface(typeof(Entity<>)))
            {
                base.Property(visitor, property);
            }
        }
    }
}