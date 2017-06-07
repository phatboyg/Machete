// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z86_GIVE (GroupMap) - 
    /// </summary>
    public class RSP_Z86_GIVEMap :
        HL7V26LayoutMap<RSP_Z86_GIVE>
    {
        public RSP_Z86_GIVEMap()
        {
            Segment(x => x.RXG, 0, x => x.Required = true);
            Segment(x => x.RXR, 1, x => x.Required = true);
            Segment(x => x.RXC, 2);
        }
    }
}