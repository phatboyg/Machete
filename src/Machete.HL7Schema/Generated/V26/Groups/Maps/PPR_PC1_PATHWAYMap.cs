// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPR_PC1_PATHWAY (GroupMap) - 
    /// </summary>
    public class PPR_PC1_PATHWAYMap :
        HL7TemplateMap<PPR_PC1_PATHWAY>
    {
        public PPR_PC1_PATHWAYMap()
        {
            Segment(x => x.PTH, 0, x => x.Required = true);
            Segments(x => x.VAR, 1);
        }
    }
}