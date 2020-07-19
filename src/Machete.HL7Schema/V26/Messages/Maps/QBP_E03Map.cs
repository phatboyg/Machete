// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QBP_E03 (MessageMap) - 
    /// </summary>
    public class QBP_E03Map :
        HL7V26LayoutMap<QBP_E03>
    {
        public QBP_E03Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.QPD, 3, x => x.Required = true);
            Segment(x => x.RCP, 4, x => x.Required = true);
        }
    }
}