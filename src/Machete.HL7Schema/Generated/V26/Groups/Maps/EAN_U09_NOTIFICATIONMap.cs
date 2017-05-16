// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EAN_U09_NOTIFICATION (GroupMap) - 
    /// </summary>
    public class EAN_U09_NOTIFICATIONMap :
        HL7LayoutMap<EAN_U09_NOTIFICATION>
    {
        public EAN_U09_NOTIFICATIONMap()
        {
            Segment(x => x.NDS, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}