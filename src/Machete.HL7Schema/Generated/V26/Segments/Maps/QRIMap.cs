// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QRI (SegmentMap) - Query Response Instance
    /// </summary>
    public class QRIMap :
        HL7SegmentMap<QRI>
    {
        public QRIMap()
        {
            Id = "QRI";

            Name = "Query Response Instance";

            Value(x => x.CandidateConfidence, 1);
            Value(x => x.MatchReasonCode, 2);
            Entity(x => x.AlgorithmDescriptor, 3);
        }
    }
}