// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORL_O22_ORDER (GroupMap) - 
    /// </summary>
    public class ORL_O22_ORDERMap :
        HL7V26LayoutMap<ORL_O22_ORDER>
    {
        public ORL_O22_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Layout(x => x.ObservationRequest, 2);
        }
    }
}