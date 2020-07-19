// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z82_TREATMENT (GroupMap) - 
    /// </summary>
    public class RSP_Z82_TREATMENTMap :
        HL7V26LayoutMap<RSP_Z82_TREATMENT>
    {
        public RSP_Z82_TREATMENTMap()
        {
            Segment(x => x.RXC, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}