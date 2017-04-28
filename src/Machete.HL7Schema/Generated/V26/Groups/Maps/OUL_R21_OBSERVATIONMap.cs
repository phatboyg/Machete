// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R21_OBSERVATION (GroupMap) - 
    /// </summary>
    public class OUL_R21_OBSERVATIONMap :
        HL7TemplateMap<OUL_R21_OBSERVATION>
    {
        public OUL_R21_OBSERVATIONMap()
        {
            Map(x => x.OBX, 0);
            Map(x => x.TCD, 1);
            Map(x => x.SID, 2);
            Map(x => x.NTE, 3);
        }
    }
}