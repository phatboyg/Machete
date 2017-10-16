namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CRC : X12Segment
    {
        Value<string> CodeCategory { get; }

        Value<string> CertificationConditionIndicator { get; }

        Value<string> FunctionalLimitationCode { get; }

        Value<string> FunctionalLimitationCode2 { get; }

        Value<string> FunctionalLimitationCode3 { get; }

        Value<string> FunctionalLimitationCode4 { get; }

        Value<string> FunctionalLimitationCode5 { get; }
    }
}