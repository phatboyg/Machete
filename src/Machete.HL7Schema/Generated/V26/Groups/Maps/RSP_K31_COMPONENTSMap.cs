// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_K31_COMPONENTS (GroupMap) - 
    /// </summary>
    public class RSP_K31_COMPONENTSMap :
        HL7LayoutMap<RSP_K31_COMPONENTS>
    {
        public RSP_K31_COMPONENTSMap()
        {
            Segment(x => x.RXC, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}