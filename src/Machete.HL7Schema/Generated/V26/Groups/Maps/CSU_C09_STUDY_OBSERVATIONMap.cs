// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSU_C09_STUDY_OBSERVATION (GroupMap) - 
    /// </summary>
    public class CSU_C09_STUDY_OBSERVATIONMap :
        HL7TemplateMap<CSU_C09_STUDY_OBSERVATION>
    {
        public CSU_C09_STUDY_OBSERVATIONMap()
        {
            Map(x => x.ORC, 0);
            Map(x => x.OBR, 1, x => x.Required = true);
            Map(x => x.ROL, 2);
            Map(x => x.TimingQty, 3);
            Map(x => x.OBX, 4, x => x.Required = true);
        }
    }
}