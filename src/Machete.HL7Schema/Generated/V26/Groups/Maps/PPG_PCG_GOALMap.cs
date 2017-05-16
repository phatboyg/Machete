// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPG_PCG_GOAL (GroupMap) - 
    /// </summary>
    public class PPG_PCG_GOALMap :
        HL7LayoutMap<PPG_PCG_GOAL>
    {
        public PPG_PCG_GOALMap()
        {
            Segment(x => x.GOL, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.VAR, 2);
            Layout(x => x.GoalRole, 3);
            Layout(x => x.GoalObservation, 4);
            Layout(x => x.Problem, 5);
            Layout(x => x.Order, 6);
        }
    }
}