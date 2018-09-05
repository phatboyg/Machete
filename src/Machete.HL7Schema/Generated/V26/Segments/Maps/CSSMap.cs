// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSS (SegmentMap) - Clinical Study Data Schedule Segment
    /// </summary>
    public class CSSMap :
        HL7V26SegmentMap<CSS>
    {
        public CSSMap()
        {
            Id = "CSS";

            Name = "Clinical Study Data Schedule Segment";

            Entity(x => x.StudyScheduledTimePoint, 1, x => x.IsRequired());
            Value(x => x.StudyScheduledPatientTimePoint, 2, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.StudyQualityControlCodes, 3);
        }
    }
}