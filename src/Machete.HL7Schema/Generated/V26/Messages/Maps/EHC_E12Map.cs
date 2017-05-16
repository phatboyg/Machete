// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E12 (MessageMap) - 
    /// </summary>
    public class EHC_E12Map :
        HL7LayoutMap<EHC_E12>
    {
        public EHC_E12Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.RFI, 3, x => x.Required = true);
            Segment(x => x.CTD, 4);
            Segment(x => x.IVC, 5, x => x.Required = true);
            Segment(x => x.PSS, 6, x => x.Required = true);
            Segment(x => x.PSG, 7, x => x.Required = true);
            Segment(x => x.PID, 8);
            Segment(x => x.PSL, 9);
            Layout(x => x.Request, 10, x => x.Required = true);
        }
    }
}