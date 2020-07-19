// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// STZ (SegmentMap) - Sterilization Parameter
    /// </summary>
    public class STZMap :
        HL7V26SegmentMap<STZ>
    {
        public STZMap()
        {
            Id = "STZ";

            Name = "Sterilization Parameter";

            Entity(x => x.SterilizationType, 1);
            Entity(x => x.SterilizationCycle, 2);
            Entity(x => x.MaintenanceCycle, 3);
            Entity(x => x.MaintenanceType, 4);
        }
    }
}