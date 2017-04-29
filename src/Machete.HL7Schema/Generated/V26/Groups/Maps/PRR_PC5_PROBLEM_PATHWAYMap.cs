// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRR_PC5_PROBLEM_PATHWAY (GroupMap) - 
    /// </summary>
    public class PRR_PC5_PROBLEM_PATHWAYMap :
        HL7TemplateMap<PRR_PC5_PROBLEM_PATHWAY>
    {
        public PRR_PC5_PROBLEM_PATHWAYMap()
        {
            Segment(x => x.PTH, 0, x => x.Required = true);
            Segments(x => x.VAR, 1);
        }
    }
}