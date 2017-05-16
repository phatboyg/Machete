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
        HL7LayoutMap<CSU_C09_STUDY_OBSERVATION>
    {
        public CSU_C09_STUDY_OBSERVATIONMap()
        {
            Segment(x => x.ORC, 0);
            Segment(x => x.OBR, 1, x => x.Required = true);
            Segment(x => x.ROL, 2);
            Layout(x => x.TimingQty, 3);
            Segment(x => x.OBX, 4, x => x.Required = true);
        }
    }
}