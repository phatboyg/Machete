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
        HL7TemplateMap<OUL_R24_ORDER>
    {
        public OUL_R24_ORDERMap()
        {
            Segment(x => x.OBR, 0, x => x.Required = true);
            Segment(x => x.ORC, 1);
            Segments(x => x.NTE, 2);
            Segments(x => x.ROL, 3);
            Groups(x => x.TimingQty, 4);
            Groups(x => x.Specimen, 5);
            Groups(x => x.Result, 6);
            Segments(x => x.CTI, 7);
        }
    }
}