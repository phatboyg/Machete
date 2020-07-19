// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RXC (SegmentMap) - Pharmacy/Treatment Component Order
    /// </summary>
    public class RXCMap :
        HL7V26SegmentMap<RXC>
    {
        public RXCMap()
        {
            Id = "RXC";

            Name = "Pharmacy/Treatment Component Order";

            Value(x => x.RXComponentType, 1, x => x.IsRequired());
            Entity(x => x.ComponentCode, 2, x => x.IsRequired());
            Value(x => x.ComponentAmount, 3, x => x.IsRequired());
            Entity(x => x.ComponentUnits, 4, x => x.IsRequired());
            Value(x => x.ComponentStrength, 5);
            Entity(x => x.ComponentStrengthUnits, 6);
            Entity(x => x.SupplementaryCode, 7);
            Value(x => x.ComponentDrugStrengthVolume, 8);
            Entity(x => x.ComponentDrugStrengthVolumeUnits, 9);
        }
    }
}