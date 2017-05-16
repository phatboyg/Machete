// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORP_O10_PATIENT (GroupMap) - 
    /// </summary>
    public class ORP_O10_PATIENTMap :
        HL7LayoutMap<ORP_O10_PATIENT>
    {
        public ORP_O10_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}