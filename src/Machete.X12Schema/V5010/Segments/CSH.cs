namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface CSH :
        X12Segment
    {
        Value<string> SalesRequirementCode { get; }
        
        Value<string> ActionCode { get; }
        
        Value<decimal> Amount { get; }
        
        Value<string> AccountNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> SpecialServicesCode { get; }
        
        Value<string> ProductOrServiceSubstitutionCode { get; }
        
        Value<decimal> PercentageAsDecimal { get; }
        
        Value<int> PercentQualifier { get; }
    }
}