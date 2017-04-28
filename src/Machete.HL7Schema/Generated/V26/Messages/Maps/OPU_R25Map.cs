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
        HL7TemplateMap<OPU_R25>
    {
        public OPU_R25Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.NTE, 3);
            Map(x => x.PV1, 4, x => x.Required = true);
            Map(x => x.PV2, 5);
            Map(x => x.OBX, 6);
            Map(x => x.NTE2, 7);
            Map(x => x.ROL, 8, x => x.Required = true);
            Map(x => x.AccessionDetail, 9, x => x.Required = true);
        }
    }
}