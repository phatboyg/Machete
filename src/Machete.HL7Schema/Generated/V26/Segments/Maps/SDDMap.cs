// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SDD (SegmentMap) - Sterilization Device Data
    /// </summary>
    public class SDDMap :
        HL7SegmentMap<SDD>
    {
        public SDDMap()
        {
            Id = "SDD";

            Name = "Sterilization Device Data";

            Entity(x => x.LotNumber, 1);
            Entity(x => x.DeviceNumber, 2);
            Value(x => x.DeviceName, 3);
            Value(x => x.DeviceDataState, 4);
            Value(x => x.LoadStatus, 5);
            Value(x => x.ControlCode, 6);
            Value(x => x.OperatorName, 7);
        }
    }
}