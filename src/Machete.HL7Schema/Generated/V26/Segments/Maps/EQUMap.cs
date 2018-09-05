// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EQU (SegmentMap) - Equipment Detail
    /// </summary>
    public class EQUMap :
        HL7V26SegmentMap<EQU>
    {
        public EQUMap()
        {
            Id = "EQU";

            Name = "Equipment Detail";

            Entity(x => x.EquipmentInstanceIdentifier, 1, x => x.IsRequired());
            Value(x => x.EventDateTime, 2, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.EquipmentState, 3);
            Entity(x => x.LocalRemoteControlState, 4);
            Entity(x => x.AlertLevel, 5);
        }
    }
}