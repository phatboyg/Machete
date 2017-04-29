// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPV_PCA_GOAL (GroupMap) - 
    /// </summary>
    public class PPV_PCA_GOALMap :
        HL7TemplateMap<PPV_PCA_GOAL>
    {
        public PPV_PCA_GOALMap()
        {
            Segment(x => x.GOL, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.VAR, 2);
            Groups(x => x.GoalRole, 3);
            Groups(x => x.GoalPathway, 4);
            Groups(x => x.GoalObservation, 5);
            Groups(x => x.Problem, 6);
            Groups(x => x.Order, 7);
        }
    }
}