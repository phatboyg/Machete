// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDR_RDR_PATIENT (GroupMap) - 
    /// </summary>
    public class RDR_RDR_PATIENTMap :
        HL7V26LayoutMap<RDR_RDR_PATIENT>
    {
        public RDR_RDR_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}