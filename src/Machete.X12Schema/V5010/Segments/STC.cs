namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface STC :
        X12Segment
    {
        Value<C043> HealthcareClaimStatus1 { get; }
        
        Value<DateTime> StatusInformationEffectiveDate { get; }
        
        Value<string> ActionCode { get; }
        
        Value<decimal> TotalSubmittedChargesForUnitWork { get; }
        
        Value<C043> HealthcareClaimStatus2 { get; }
        
        Value<C043> HealthcareClaimStatus3 { get; }
    }
}