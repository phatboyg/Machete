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
            Map(x => x.PRB, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.VAR, 2);
            Map(x => x.ProblemRole, 3);
            Map(x => x.ProblemPathway, 4);
            Map(x => x.ProblemObservation, 5);
            Map(x => x.Goal, 6);
            Map(x => x.Order, 7);
        }
    }
}