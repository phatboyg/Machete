// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R23_RESULT (GroupMap) - 
    /// </summary>
    public class OUL_R23_RESULTMap :
        HL7TemplateMap<OUL_R23_RESULT>
    {
        public OUL_R23_RESULTMap()
        {
            Map(x => x.OBX, 0, x => x.Required = true);
            Map(x => x.TCD, 1);
            Map(x => x.SID, 2);
            Map(x => x.NTE, 3);
        }
    }
}