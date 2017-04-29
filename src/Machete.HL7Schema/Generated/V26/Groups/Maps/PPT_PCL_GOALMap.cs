// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPT_PCL_GOAL (GroupMap) - 
    /// </summary>
    public class PPT_PCL_GOALMap :
        HL7TemplateMap<PPT_PCL_GOAL>
    {
        public PPT_PCL_GOALMap()
        {
            Segment(x => x.GOL, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.VAR, 2);
            Groups(x => x.GoalRole, 3);
            Groups(x => x.GoalObservation, 4);
            Groups(x => x.Problem, 5);
            Groups(x => x.Order, 6);
        }
    }
}