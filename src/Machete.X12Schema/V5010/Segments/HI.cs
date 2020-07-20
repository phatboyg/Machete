namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface HI :
        X12Segment
    {
        Value<C022> HealthCareCodeInformation1 { get; }

        Value<C022> HealthCareCodeInformation2 { get; }

        Value<C022> HealthCareCodeInformation3 { get; }

        Value<C022> HealthCareCodeInformation4 { get; }

        Value<C022> HealthCareCodeInformation5 { get; }

        Value<C022> HealthCareCodeInformation6 { get; }

        Value<C022> HealthCareCodeInformation7 { get; }

        Value<C022> HealthCareCodeInformation8 { get; }

        Value<C022> HealthCareCodeInformation9 { get; }

        Value<C022> HealthCareCodeInformation10 { get; }

        Value<C022> HealthCareCodeInformation11 { get; }

        Value<C022> HealthCareCodeInformation12 { get; }
    }
}