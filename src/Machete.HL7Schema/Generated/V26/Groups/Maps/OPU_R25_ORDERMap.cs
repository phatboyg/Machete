// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPU_R25_ORDER (GroupMap) - 
    /// </summary>
    public class OPU_R25_ORDERMap :
        HL7LayoutMap<OPU_R25_ORDER>
    {
        public OPU_R25_ORDERMap()
        {
            Segment(x => x.OBR, 0, x => x.Required = true);
            Segment(x => x.ORC, 1);
            Segment(x => x.NTE, 2);
            Segment(x => x.ROL, 3);
            Layout(x => x.TimingQty, 4);
            Layout(x => x.Result, 5, x => x.Required = true);
        }
    }
}