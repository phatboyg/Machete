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
            Map(x => x.PRB, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.VAR, 2);
            Map(x => x.ProblemRole, 3);
            Map(x => x.Pathway, 4);
            Map(x => x.ProblemObservation, 5);
            Map(x => x.Goal, 6);
            Map(x => x.Order, 7);
        }
    }
}