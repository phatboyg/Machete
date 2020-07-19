// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SCP (SegmentMap) - Sterilizer Configuration Segment
    /// </summary>
    public class SCPMap :
        HL7V26SegmentMap<SCP>
    {
        public SCPMap()
        {
            Id = "SCP";

            Name = "Sterilizer Configuration Segment";

            Value(x => x.NumberOfDecontaminationSterilizationDevices, 1);
            Entity(x => x.LaborCalculationType, 2);
            Entity(x => x.DateFormat, 3);
            Entity(x => x.DeviceNumber, 4);
            Value(x => x.DeviceName, 5);
            Value(x => x.DeviceModelName, 6);
            Entity(x => x.DeviceType, 7);
            Entity(x => x.LotControl, 8);
        }
    }
}