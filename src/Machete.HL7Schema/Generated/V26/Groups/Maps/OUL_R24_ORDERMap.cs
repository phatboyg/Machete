// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R24_ORDER (GroupMap) - 
    /// </summary>
    public class OUL_R24_ORDERMap :
        HL7LayoutMap<OUL_R24_ORDER>
    {
        public OUL_R24_ORDERMap()
        {
            Segment(x => x.OBR, 0, x => x.Required = true);
            Segment(x => x.ORC, 1);
            Segment(x => x.NTE, 2);
            Segment(x => x.ROL, 3);
            Layout(x => x.TimingQty, 4);
            Layout(x => x.Specimen, 5);
            Layout(x => x.Result, 6);
            Segment(x => x.CTI, 7);
        }
    }
}