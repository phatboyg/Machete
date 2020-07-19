// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSU_C09_RX_ADMIN (GroupMap) - 
    /// </summary>
    public class CSU_C09_RX_ADMINMap :
        HL7V26LayoutMap<CSU_C09_RX_ADMIN>
    {
        public CSU_C09_RX_ADMINMap()
        {
            Segment(x => x.RXA, 0, x => x.Required = true);
            Segment(x => x.RXR, 1, x => x.Required = true);
        }
    }
}