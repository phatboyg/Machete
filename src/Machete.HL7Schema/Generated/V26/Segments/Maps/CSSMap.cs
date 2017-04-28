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
        HL7SegmentMap<CSS>
    {
        public CSSMap()
        {
            Id = "CSS";

            Name = "Clinical Study Data Schedule Segment";

            Entity(x => x.StudyScheduledTimePoint, 1, x => {x.Required = true;});
            Value(x => x.StudyScheduledPatientTimePoint, 2, x => {x.Format = "LONGDATETIME2";});
            Entity(x => x.StudyQualityControlCodes, 3);
        }
    }
}