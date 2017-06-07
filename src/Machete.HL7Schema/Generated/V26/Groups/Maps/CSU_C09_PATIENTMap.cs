// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSU_C09_PATIENT (GroupMap) - 
    /// </summary>
    public class CSU_C09_PATIENTMap :
        HL7V26LayoutMap<CSU_C09_PATIENT>
    {
        public CSU_C09_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Segment(x => x.NTE, 2);
            Layout(x => x.Visit, 3);
            Segment(x => x.CSR, 4, x => x.Required = true);
            Layout(x => x.StudyPhase, 5, x => x.Required = true);
        }
    }
}