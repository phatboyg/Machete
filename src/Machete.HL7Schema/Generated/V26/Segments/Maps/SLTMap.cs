// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SLT (SegmentMap) - Sterilization Lot
    /// </summary>
    public class SLTMap :
        HL7V26SegmentMap<SLT>
    {
        public SLTMap()
        {
            Id = "SLT";

            Name = "Sterilization Lot";

            Entity(x => x.DeviceNumber, 1);
            Value(x => x.DeviceName, 2);
            Entity(x => x.LotNumber, 3);
            Entity(x => x.ItemIdentifier, 4);
            Value(x => x.BarCode, 5);
        }
    }
}