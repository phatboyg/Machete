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
        HL7TemplateMap<OMG_O19_ORDER_PRIOR>
    {
        public OMG_O19_ORDER_PRIORMap()
        {
            Map(x => x.ORC, 0);
            Map(x => x.OBR, 1, x => x.Required = true);
            Map(x => x.TimingPrior, 2);
            Map(x => x.NTE, 3);
            Map(x => x.ROL, 4);
            Map(x => x.CTD, 5);
            Map(x => x.ObservationPrior, 6, x => x.Required = true);
        }
    }
}