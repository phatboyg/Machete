namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface HI : X12Segment
    {
        Value<string> HealthCareCodeInformation { get; }

        Value<string> HealthCareCodeInformation2 { get; }

        Value<string> HealthCareCodeInformation3 { get; }

        Value<string> HealthCareCodeInformation4 { get; }

        Value<string> HealthCareCodeInformation5 { get; }

        Value<string> HealthCareCodeInformation6 { get; }

        Value<string> HealthCareCodeInformation7 { get; }

        Value<string> HealthCareCodeInformation8 { get; }

        Value<string> HealthCareCodeInformation9 { get; }

        Value<string> HealthCareCodeInformation10 { get; }

        Value<string> HealthCareCodeInformation11 { get; }

        Value<string> HealthCareCodeInformation12 { get; }
    }
}