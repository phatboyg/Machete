// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OSR_Q06 (MessageMap) - 
    /// </summary>
    public class OSR_Q06Map :
        HL7V26LayoutMap<OSR_Q06>
    {
        public OSR_Q06Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segment(x => x.ERR, 2);
            Segment(x => x.SFT, 3);
            Segment(x => x.UAC, 4);
            Segment(x => x.NTE, 5);
            Segment(x => x.QRD, 6, x => x.Required = true);
            Segment(x => x.QRF, 7);
            Layout(x => x.Response, 8);
            Segment(x => x.DSC, 9);
        }
    }
}