// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSU_C09_STUDY_PHARM (GroupMap) - 
    /// </summary>
    public class CSU_C09_STUDY_PHARMMap :
        HL7TemplateMap<CSU_C09_STUDY_PHARM>
    {
        public CSU_C09_STUDY_PHARMMap()
        {
            Map(x => x.ORC, 0);
            Map(x => x.RxAdmin, 1, x => x.Required = true);
        }
    }
}