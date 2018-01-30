namespace Machete.X12Schema.V5010
{
    using Components;
    using X12;
    
    
    public interface HI :
        X12Segment
    {
        Value<HealthCareCode> HealthCareCodeInformation1 { get; }

        Value<HealthCareCode> HealthCareCodeInformation2 { get; }

        Value<HealthCareCode> HealthCareCodeInformation3 { get; }

        Value<HealthCareCode> HealthCareCodeInformation4 { get; }

        Value<HealthCareCode> HealthCareCodeInformation5 { get; }

        Value<HealthCareCode> HealthCareCodeInformation6 { get; }

        Value<HealthCareCode> HealthCareCodeInformation7 { get; }

        Value<HealthCareCode> HealthCareCodeInformation8 { get; }

        Value<HealthCareCode> HealthCareCodeInformation9 { get; }

        Value<HealthCareCode> HealthCareCodeInformation10 { get; }

        Value<HealthCareCode> HealthCareCodeInformation11 { get; }

        Value<HealthCareCode> HealthCareCodeInformation12 { get; }
    }
}