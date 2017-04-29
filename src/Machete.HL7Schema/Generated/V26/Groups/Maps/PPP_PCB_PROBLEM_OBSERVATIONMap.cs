// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPP_PCB_PROBLEM_OBSERVATION (GroupMap) - 
    /// </summary>
    public class PPP_PCB_PROBLEM_OBSERVATIONMap :
        HL7TemplateMap<PPP_PCB_PROBLEM_OBSERVATION>
    {
        public PPP_PCB_PROBLEM_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}