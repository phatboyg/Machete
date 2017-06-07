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
        HL7V26LayoutMap<PPV_PCA_GOAL>
    {
        public PPV_PCA_GOALMap()
        {
            Segment(x => x.GOL, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.VAR, 2);
            Layout(x => x.GoalRole, 3);
            Layout(x => x.GoalPathway, 4);
            Layout(x => x.GoalObservation, 5);
            Layout(x => x.Problem, 6);
            Layout(x => x.Order, 7);
        }
    }
}