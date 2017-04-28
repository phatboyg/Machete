// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z90_SPECIMEN (GroupMap) - 
    /// </summary>
    public class RSP_Z90_SPECIMENMap :
        HL7TemplateMap<RSP_Z90_SPECIMEN>
    {
        public RSP_Z90_SPECIMENMap()
        {
            Map(x => x.SPM, 0, x => x.Required = true);
            Map(x => x.OBX, 1);
        }
    }
}