// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQC_I05 (MessageMap) - 
    /// </summary>
    public class RQC_I05Map :
        HL7V26LayoutMap<RQC_I05>
    {
        public RQC_I05Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.QRD, 3, x => x.Required = true);
            Segment(x => x.QRF, 4);
            Layout(x => x.Provider, 5, x => x.Required = true);
            Segment(x => x.PID, 6, x => x.Required = true);
            Segment(x => x.NK1, 7);
            Segment(x => x.GT1, 8);
            Segment(x => x.NTE, 9);
        }
    }
}