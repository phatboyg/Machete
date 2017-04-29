// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O35_ORDER_PRIOR (GroupMap) - 
    /// </summary>
    public class OML_O35_ORDER_PRIORMap :
        HL7TemplateMap<OML_O35_ORDER_PRIOR>
    {
        public OML_O35_ORDER_PRIORMap()
        {
            Segment(x => x.ORC, 0);
            Segment(x => x.OBR, 1, x => x.Required = true);
            Segments(x => x.NTE, 2);
            Segments(x => x.ROL, 3);
            Groups(x => x.TimingPrior, 4);
            Groups(x => x.ObservationPrior, 5, x => x.Required = true);
        }
    }
}