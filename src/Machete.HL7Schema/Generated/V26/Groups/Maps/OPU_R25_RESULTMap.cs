// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPU_R25_RESULT (GroupMap) - 
    /// </summary>
    public class OPU_R25_RESULTMap :
        HL7LayoutMap<OPU_R25_RESULT>
    {
        public OPU_R25_RESULTMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}