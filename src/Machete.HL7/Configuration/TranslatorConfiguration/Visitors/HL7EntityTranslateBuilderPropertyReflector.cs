namespace Machete.HL7.TranslatorConfiguration.Visitors
{
    using System;
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
                HandlePropertyType(visitor, property, typeof(Segment<>), "Segment");
            else if (property.PropertyType.HasInterface(typeof(SegmentList<>)))
                HandlePropertyType(visitor, property, typeof(SegmentList<>), "SegmentList");
            else
                base.Property(visitor, property);
        }

        void HandlePropertyType(TVisitor visitor, PropertyInfo property, Type type, string methodName)
        {
            var propertyType = property.PropertyType.GetClosingArguments(type).Single();

            var methodType = typeof(TVisitor)
                .GetMethod(methodName)
                ?.MakeGenericMethod(propertyType);

            CompileCallMethod(methodType)(visitor, property);
        }
    }
}