// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PTR_PCF_GOAL (GroupMap) - 
    /// </summary>
    public class PTR_PCF_GOALMap :
        HL7LayoutMap<PTR_PCF_GOAL>
    {
        public PTR_PCF_GOALMap()
        {
            Segment(x => x.GOL, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.VAR, 2);
            Layout(x => x.GoalRole, 3);
            Layout(x => x.GoalObservation, 4);
        }
    }
}