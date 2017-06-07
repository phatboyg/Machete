// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z90_COMMON_ORDER (GroupMap) - 
    /// </summary>
    public class RSP_Z90_COMMON_ORDERMap :
        HL7V26LayoutMap<RSP_Z90_COMMON_ORDER>
    {
        public RSP_Z90_COMMON_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Segment(x => x.OBR, 2, x => x.Required = true);
            Segment(x => x.NTE, 3);
            Segment(x => x.CTD, 4);
            Layout(x => x.Observation, 5, x => x.Required = true);
        }
    }
}