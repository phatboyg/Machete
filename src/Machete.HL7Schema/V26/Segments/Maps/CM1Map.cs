// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CM1 (SegmentMap) - Clinical Study Phase Master
    /// </summary>
    public class CM1Map :
        HL7V26SegmentMap<CM1>
    {
        public CM1Map()
        {
            Id = "CM1";

            Name = "Clinical Study Phase Master";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.StudyPhaseIdentifier, 2, x => x.IsRequired());
            Value(x => x.DescriptionOfStudyPhase, 3, x => x.IsRequired());
        }
    }
}