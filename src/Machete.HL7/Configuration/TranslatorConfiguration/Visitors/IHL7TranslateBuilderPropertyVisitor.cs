namespace Machete.HL7.TranslatorConfiguration.Visitors
{
    using System.Reflection;
    using Machete.TranslatorConfiguration.Visitors;


    public interface IHL7TranslateBuilderPropertyVisitor<in TSchema> :
        ITranslateBuilderPropertyVisitor<TSchema>
        where TSchema : HL7Entity
    {
        void Segment<T>(PropertyInfo property)
            where T : HL7Segment;

        void SegmentList<T>(PropertyInfo property)
            where T : HL7Segment;
    }
}