// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ODT (SegmentMap) - Diet Tray Instructions
    /// </summary>
    public class ODTMap :
        HL7V26SegmentMap<ODT>
    {
        public ODTMap()
        {
            Id = "ODT";

            Name = "Diet Tray Instructions";

            Entity(x => x.TrayType, 1, x => x.IsRequired());
            Entity(x => x.ServicePeriod, 2);
            Value(x => x.TextInstruction, 3);
        }
    }
}