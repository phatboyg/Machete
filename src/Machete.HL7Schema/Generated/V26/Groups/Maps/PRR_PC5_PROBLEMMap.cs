// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRR_PC5_PROBLEM (GroupMap) - 
    /// </summary>
    public class PRR_PC5_PROBLEMMap :
        HL7LayoutMap<PRR_PC5_PROBLEM>
    {
        public PRR_PC5_PROBLEMMap()
        {
            Segment(x => x.PRB, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.VAR, 2);
            Layout(x => x.ProblemRole, 3);
            Layout(x => x.ProblemPathway, 4);
            Layout(x => x.ProblemObservation, 5);
            Layout(x => x.Goal, 6);
            Layout(x => x.Order, 7);
        }
    }
}