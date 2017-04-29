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
        HL7TemplateMap<PRR_PC5_PROBLEM>
    {
        public PRR_PC5_PROBLEMMap()
        {
            Segment(x => x.PRB, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.VAR, 2);
            Groups(x => x.ProblemRole, 3);
            Groups(x => x.ProblemPathway, 4);
            Groups(x => x.ProblemObservation, 5);
            Groups(x => x.Goal, 6);
            Groups(x => x.Order, 7);
        }
    }
}