// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M07_MF_CLIN_STUDY_SCHED (GroupMap) - 
    /// </summary>
    public class MFN_M07_MF_CLIN_STUDY_SCHEDMap :
        HL7V26LayoutMap<MFN_M07_MF_CLIN_STUDY_SCHED>
    {
        public MFN_M07_MF_CLIN_STUDY_SCHEDMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.CM0, 1, x => x.Required = true);
            Segment(x => x.CM2, 2);
        }
    }
}