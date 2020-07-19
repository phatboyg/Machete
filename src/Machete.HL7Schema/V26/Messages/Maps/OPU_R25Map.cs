// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPU_R25 (MessageMap) - 
    /// </summary>
    public class OPU_R25Map :
        HL7V26LayoutMap<OPU_R25>
    {
        public OPU_R25Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.NTE, 3);
            Segment(x => x.PV1, 4, x => x.Required = true);
            Segment(x => x.PV2, 5);
            Segment(x => x.OBX, 6);
            Segment(x => x.NTE2, 7);
            Segment(x => x.ROL, 8, x => x.Required = true);
            Layout(x => x.AccessionDetail, 9, x => x.Required = true);
        }
    }
}