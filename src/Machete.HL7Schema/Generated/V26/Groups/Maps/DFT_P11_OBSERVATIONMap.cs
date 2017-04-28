// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P11_OBSERVATION (GroupMap) - 
    /// </summary>
    public class DFT_P11_OBSERVATIONMap :
        HL7TemplateMap<DFT_P11_OBSERVATION>
    {
        public DFT_P11_OBSERVATIONMap()
        {
            Map(x => x.OBX, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}