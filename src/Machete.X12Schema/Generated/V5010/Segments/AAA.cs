namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface AAA :
        X12Segment
    {
        Value<string> ConditionResponseCode { get; }

        Value<string> RejectReasonCode { get; }

        Value<string> FollowUpActionCode { get; }
    }
}