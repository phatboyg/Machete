// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PGL_PC6_GOAL (GroupMap) - 
    /// </summary>
    public class PGL_PC6_GOALMap :
        HL7TemplateMap<PGL_PC6_GOAL>
    {
        public PGL_PC6_GOALMap()
        {
            Map(x => x.GOL, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.VAR, 2);
            Map(x => x.GoalRole, 3);
            Map(x => x.Pathway, 4);
            Map(x => x.Observation, 5);
            Map(x => x.Problem, 6);
            Map(x => x.Order, 7);
        }
    }
}