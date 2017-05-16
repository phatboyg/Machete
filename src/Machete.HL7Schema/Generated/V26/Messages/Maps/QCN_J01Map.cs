// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QCN_J01 (MessageMap) - 
    /// </summary>
    public class QCN_J01Map :
        HL7LayoutMap<QCN_J01>
    {
        public QCN_J01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.QID, 3, x => x.Required = true);
        }
    }
}