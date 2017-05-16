// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PGL_PC6_PROBLEM (GroupMap) - 
    /// </summary>
    public class PGL_PC6_PROBLEMMap :
        HL7LayoutMap<PGL_PC6_PROBLEM>
    {
        public PGL_PC6_PROBLEMMap()
        {
            Segment(x => x.PRB, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.VAR, 2);
            Layout(x => x.ProblemRole, 3);
            Layout(x => x.ProblemObservation, 4);
        }
    }
}