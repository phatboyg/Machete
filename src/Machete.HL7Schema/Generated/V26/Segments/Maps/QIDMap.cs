// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QID (SegmentMap) - Query Identification
    /// </summary>
    public class QIDMap :
        HL7V26SegmentMap<QID>
    {
        public QIDMap()
        {
            Id = "QID";

            Name = "Query Identification";

            Value(x => x.QueryTag, 1, x => x.IsRequired());
            Entity(x => x.MessageQueryName, 2, x => x.IsRequired());
        }
    }
}