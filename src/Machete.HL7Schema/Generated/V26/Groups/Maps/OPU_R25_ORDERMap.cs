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
        HL7TemplateMap<OPU_R25_ORDER>
    {
        public OPU_R25_ORDERMap()
        {
            Map(x => x.OBR, 0, x => x.Required = true);
            Map(x => x.ORC, 1);
            Map(x => x.NTE, 2);
            Map(x => x.ROL, 3);
            Map(x => x.TimingQty, 4);
            Map(x => x.Result, 5, x => x.Required = true);
        }
    }
}