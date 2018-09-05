// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QAK (SegmentMap) - Query Acknowledgment
    /// </summary>
    public class QAKMap :
        HL7V26SegmentMap<QAK>
    {
        public QAKMap()
        {
            Id = "QAK";

            Name = "Query Acknowledgment";

            Value(x => x.QueryTag, 1);
            Value(x => x.QueryResponseStatus, 2);
            Entity(x => x.MessageQueryName, 3);
            Value(x => x.HitCountTotal, 4);
            Value(x => x.ThiPayload, 5);
            Value(x => x.HitsRemaining, 6);
        }
    }
}