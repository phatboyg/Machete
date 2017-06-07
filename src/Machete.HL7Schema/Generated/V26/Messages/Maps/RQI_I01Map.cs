// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQI_I01 (MessageMap) - 
    /// </summary>
    public class RQI_I01Map :
        HL7V26LayoutMap<RQI_I01>
    {
        public RQI_I01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Layout(x => x.Provider, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.NK1, 5);
            Layout(x => x.GuarantorInsurance, 6);
            Segment(x => x.NTE, 7);
        }
    }
}