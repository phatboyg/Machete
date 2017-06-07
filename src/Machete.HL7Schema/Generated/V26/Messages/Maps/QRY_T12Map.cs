// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QRY_T12 (MessageMap) - 
    /// </summary>
    public class QRY_T12Map :
        HL7V26LayoutMap<QRY_T12>
    {
        public QRY_T12Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.QRD, 1, x => x.Required = true);
            Segment(x => x.QRF, 2);
        }
    }
}