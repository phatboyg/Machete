// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRR_S01_SCHEDULE (GroupMap) - 
    /// </summary>
    public class SRR_S01_SCHEDULEMap :
        HL7V26LayoutMap<SRR_S01_SCHEDULE>
    {
        public SRR_S01_SCHEDULEMap()
        {
            Segment(x => x.SCH, 0, x => x.Required = true);
            Segment(x => x.TQ1, 1);
            Segment(x => x.NTE, 2);
            Layout(x => x.Patient, 3);
            Layout(x => x.Resources, 4, x => x.Required = true);
        }
    }
}