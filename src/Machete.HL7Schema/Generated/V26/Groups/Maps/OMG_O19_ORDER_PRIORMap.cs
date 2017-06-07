// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMG_O19_ORDER_PRIOR (GroupMap) - 
    /// </summary>
    public class OMG_O19_ORDER_PRIORMap :
        HL7V26LayoutMap<OMG_O19_ORDER_PRIOR>
    {
        public OMG_O19_ORDER_PRIORMap()
        {
            Segment(x => x.ORC, 0);
            Segment(x => x.OBR, 1, x => x.Required = true);
            Layout(x => x.TimingPrior, 2);
            Segment(x => x.NTE, 3);
            Segment(x => x.ROL, 4);
            Segment(x => x.CTD, 5);
            Layout(x => x.ObservationPrior, 6, x => x.Required = true);
        }
    }
}