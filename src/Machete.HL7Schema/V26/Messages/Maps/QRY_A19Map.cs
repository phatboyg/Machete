// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QRY_A19 (MessageMap) - 
    /// </summary>
    public class QRY_A19Map :
        HL7V26LayoutMap<QRY_A19>
    {
        public QRY_A19Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.QRD, 3, x => x.Required = true);
            Segment(x => x.QRF, 4);
        }
    }
}