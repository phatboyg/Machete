// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPP_PCB_PATHWAY (GroupMap) - 
    /// </summary>
    public class PPP_PCB_PATHWAYMap :
        HL7TemplateMap<PPP_PCB_PATHWAY>
    {
        public PPP_PCB_PATHWAYMap()
        {
            Segment(x => x.PTH, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.VAR, 2);
            Groups(x => x.PathwayRole, 3);
            Groups(x => x.Problem, 4);
        }
    }
}