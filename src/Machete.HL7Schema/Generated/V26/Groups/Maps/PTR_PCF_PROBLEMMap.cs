// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PTR_PCF_PROBLEM (GroupMap) - 
    /// </summary>
    public class PTR_PCF_PROBLEMMap :
        HL7TemplateMap<PTR_PCF_PROBLEM>
    {
        public PTR_PCF_PROBLEMMap()
        {
            Map(x => x.PRB, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.VAR, 2);
            Map(x => x.ProblemRole, 3);
            Map(x => x.ProblemObservation, 4);
            Map(x => x.Goal, 5);
            Map(x => x.Order, 6);
        }
    }
}