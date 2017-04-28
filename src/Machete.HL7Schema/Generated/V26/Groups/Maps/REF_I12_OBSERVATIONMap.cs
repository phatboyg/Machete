// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// REF_I12_OBSERVATION (GroupMap) - 
    /// </summary>
    public class REF_I12_OBSERVATIONMap :
        HL7TemplateMap<REF_I12_OBSERVATION>
    {
        public REF_I12_OBSERVATIONMap()
        {
            Map(x => x.OBR, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.ResultNotes, 2);
        }
    }
}