namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class AAAMap :
        X12SegmentMap<AAA, X12Entity>
    {
        public AAAMap()
        {
            Id = "AAA";
            Name = "Request Validation";
            Value(x => x.ConditionResponseCode, 1, x => x.MinLength(1));
            Value(x => x.RejectReasonCode, 3, x => x.MinLength(1));
            Value(x => x.FollowUpActionCode, 4, x => x.MinLength(1));
        }
    }
}