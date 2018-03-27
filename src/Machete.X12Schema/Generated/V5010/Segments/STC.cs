namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface STC :
        X12Segment
    {
        Value<HealthcareClaimStatus> HealthcareClaimStatus { get; }
        
        Value<DateTime> StatusInformationEffectiveDate { get; }
        
        Value<string> ActionCode { get; }
        
        Value<decimal> TotalSubmittedChargesForUnitWork { get; }
        
        Value<HealthcareClaimStatus> HealthcareClaimStatus2 { get; }
        
        Value<HealthcareClaimStatus> HealthcareClaimStatus3 { get; }
    }
}