// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPP_PCB_PROBLEM_ROLE (GroupMap) - 
    /// </summary>
    public class PPP_PCB_PROBLEM_ROLEMap :
        HL7LayoutMap<PPP_PCB_PROBLEM_ROLE>
    {
        public PPP_PCB_PROBLEM_ROLEMap()
        {
            Segment(x => x.ROL, 0, x => x.Required = true);
            Segment(x => x.VAR, 1);
        }
    }
}