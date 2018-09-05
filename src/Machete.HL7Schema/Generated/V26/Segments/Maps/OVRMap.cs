// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OVR (SegmentMap) - Override Segment
    /// </summary>
    public class OVRMap :
        HL7V26SegmentMap<OVR>
    {
        public OVRMap()
        {
            Id = "OVR";

            Name = "Override Segment";

            Entity(x => x.BusinessRuleOverrideType, 1);
            Entity(x => x.BusinessRuleOverrideCode, 2);
            Value(x => x.OverrideComments, 3);
            Entity(x => x.OverrideEnteredBy, 4);
            Entity(x => x.OverrideAuthorizedBy, 5);
        }
    }
}