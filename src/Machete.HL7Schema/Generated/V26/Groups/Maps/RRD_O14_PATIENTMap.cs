// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRD_O14_PATIENT (GroupMap) - 
    /// </summary>
    public class RRD_O14_PATIENTMap :
        HL7V26LayoutMap<RRD_O14_PATIENT>
    {
        public RRD_O14_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}