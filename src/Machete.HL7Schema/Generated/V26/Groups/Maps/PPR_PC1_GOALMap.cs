// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPR_PC1_GOAL (GroupMap) - 
    /// </summary>
    public class PPR_PC1_GOALMap :
        HL7TemplateMap<PPR_PC1_GOAL>
    {
        public PPR_PC1_GOALMap()
        {
            Segment(x => x.GOL, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.VAR, 2);
            Groups(x => x.GoalRole, 3);
            Groups(x => x.GoalObservation, 4);
        }
    }
}