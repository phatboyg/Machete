// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPR_PC1_PROBLEM (GroupMap) - 
    /// </summary>
    public class PPR_PC1_PROBLEMMap :
        HL7TemplateMap<PPR_PC1_PROBLEM>
    {
        public PPR_PC1_PROBLEMMap()
        {
            Segment(x => x.PRB, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.VAR, 2);
            Groups(x => x.ProblemRole, 3);
            Groups(x => x.Pathway, 4);
            Groups(x => x.ProblemObservation, 5);
            Groups(x => x.Goal, 6);
            Groups(x => x.Order, 7);
        }
    }
}