// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_ORDER_PRIOR (GroupMap) - 
    /// </summary>
    public class OPL_O37_ORDER_PRIORMap :
        HL7TemplateMap<OPL_O37_ORDER_PRIOR>
    {
        public OPL_O37_ORDER_PRIORMap()
        {
            Segment(x => x.OBR, 0, x => x.Required = true);
            Segment(x => x.ORC, 1);
            Segments(x => x.ROL, 2);
            Group(x => x.Timing, 3);
            Segments(x => x.OBX, 4, x => x.Required = true);
        }
    }
}