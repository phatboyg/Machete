// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRR_PC5_GOAL (GroupMap) - 
    /// </summary>
    public class PRR_PC5_GOALMap :
        HL7TemplateMap<PRR_PC5_GOAL>
    {
        public PRR_PC5_GOALMap()
        {
            Map(x => x.GOL, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.VAR, 2);
            Map(x => x.GoalRole, 3);
            Map(x => x.GoalObservation, 4);
        }
    }
}