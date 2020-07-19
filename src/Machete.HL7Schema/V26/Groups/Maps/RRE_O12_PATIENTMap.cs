// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRE_O12_PATIENT (GroupMap) - 
    /// </summary>
    public class RRE_O12_PATIENTMap :
        HL7V26LayoutMap<RRE_O12_PATIENT>
    {
        public RRE_O12_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}