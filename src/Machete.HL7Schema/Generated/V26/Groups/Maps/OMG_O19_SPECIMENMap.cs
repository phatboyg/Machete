// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMG_O19_SPECIMEN (GroupMap) - 
    /// </summary>
    public class OMG_O19_SPECIMENMap :
        HL7TemplateMap<OMG_O19_SPECIMEN>
    {
        public OMG_O19_SPECIMENMap()
        {
            Map(x => x.SPM, 0, x => x.Required = true);
            Map(x => x.OBX, 1);
            Map(x => x.Container, 2);
        }
    }
}