// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SSR_U04_SPECIMEN_CONTAINER (GroupMap) - 
    /// </summary>
    public class SSR_U04_SPECIMEN_CONTAINERMap :
        HL7TemplateMap<SSR_U04_SPECIMEN_CONTAINER>
    {
        public SSR_U04_SPECIMEN_CONTAINERMap()
        {
            Map(x => x.SAC, 0, x => x.Required = true);
            Map(x => x.SPM, 1);
        }
    }
}