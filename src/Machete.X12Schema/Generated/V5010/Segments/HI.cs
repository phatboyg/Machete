namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface HI :
        X12Segment
    {
        Value<HealthcareCode> HealthCareCodeInformation1 { get; }

        Value<HealthcareCode> HealthCareCodeInformation2 { get; }

        Value<HealthcareCode> HealthCareCodeInformation3 { get; }

        Value<HealthcareCode> HealthCareCodeInformation4 { get; }

        Value<HealthcareCode> HealthCareCodeInformation5 { get; }

        Value<HealthcareCode> HealthCareCodeInformation6 { get; }

        Value<HealthcareCode> HealthCareCodeInformation7 { get; }

        Value<HealthcareCode> HealthCareCodeInformation8 { get; }

        Value<HealthcareCode> HealthCareCodeInformation9 { get; }

        Value<HealthcareCode> HealthCareCodeInformation10 { get; }

        Value<HealthcareCode> HealthCareCodeInformation11 { get; }

        Value<HealthcareCode> HealthCareCodeInformation12 { get; }
    }
}