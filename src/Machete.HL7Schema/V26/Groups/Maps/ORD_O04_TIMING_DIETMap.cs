// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORD_O04_TIMING_DIET (GroupMap) - 
    /// </summary>
    public class ORD_O04_TIMING_DIETMap :
        HL7V26LayoutMap<ORD_O04_TIMING_DIET>
    {
        public ORD_O04_TIMING_DIETMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segment(x => x.TQ2, 1);
        }
    }
}