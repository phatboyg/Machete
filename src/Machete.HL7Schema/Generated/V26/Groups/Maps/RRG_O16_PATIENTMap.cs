// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRG_O16_PATIENT (GroupMap) - 
    /// </summary>
    public class RRG_O16_PATIENTMap :
        HL7LayoutMap<RRG_O16_PATIENT>
    {
        public RRG_O16_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}