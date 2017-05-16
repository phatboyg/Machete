// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PGL_PC6_PATHWAY (GroupMap) - 
    /// </summary>
    public class PGL_PC6_PATHWAYMap :
        HL7LayoutMap<PGL_PC6_PATHWAY>
    {
        public PGL_PC6_PATHWAYMap()
        {
            Segment(x => x.PTH, 0, x => x.Required = true);
            Segment(x => x.VAR, 1);
        }
    }
}