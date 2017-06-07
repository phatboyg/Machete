// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// UDM_Q05 (MessageMap) - 
    /// </summary>
    public class UDM_Q05Map :
        HL7V26LayoutMap<UDM_Q05>
    {
        public UDM_Q05Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.URD, 3, x => x.Required = true);
            Segment(x => x.URS, 4);
            Segment(x => x.DSP, 5, x => x.Required = true);
            Segment(x => x.DSC, 6);
        }
    }
}