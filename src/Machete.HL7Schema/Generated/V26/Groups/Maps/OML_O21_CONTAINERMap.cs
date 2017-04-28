// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O21_CONTAINER (GroupMap) - 
    /// </summary>
    public class OML_O21_CONTAINERMap :
        HL7TemplateMap<OML_O21_CONTAINER>
    {
        public OML_O21_CONTAINERMap()
        {
            Map(x => x.SAC, 0, x => x.Required = true);
            Map(x => x.OBX, 1);
        }
    }
}