namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CRC :
        X12Segment
    {
        Value<string> CodeCategory { get; }

        Value<string> CertificationConditionIndicator { get; }

        Value<string> ConditionCode1 { get; }

        Value<string> ConditionCode2 { get; }

        Value<string> ConditionCode3 { get; }

        Value<string> ConditionCode4 { get; }

        Value<string> ConditionCode5 { get; }
    }
}