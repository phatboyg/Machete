// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CTI (SegmentMap) - Clinical Trial Identification
    /// </summary>
    public class CTIMap :
        HL7V26SegmentMap<CTI>
    {
        public CTIMap()
        {
            Id = "CTI";

            Name = "Clinical Trial Identification";

            Entity(x => x.SponsorStudyId, 1, x => x.IsRequired());
            Entity(x => x.StudyPhaseIdentifier, 2);
            Entity(x => x.StudyScheduledTimePoint, 3);
        }
    }
}