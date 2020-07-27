namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface IT8 :
        X12Segment
    {
        Value<string> SalesRequirementCode { get; }
        
        Value<string> ActionCode { get; }
        
        Value<decimal> Amount { get; }
        
        Value<string> AccountNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> ProductOrServiceSubstitutionCode { get; }
        
        Value<string> ProductOrServiceIdQualifier1 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> ProductOrServiceIdQualifier2 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
        
        Value<string> ProductOrServiceIdQualifier3 { get; }
        
        Value<string> ProductOrServiceId3 { get; }
        
        Value<string> ProductOrServiceIdQualifier4 { get; }
        
        Value<string> ProductOrServiceId4 { get; }
        
        Value<string> ProductOrServiceIdQualifier5 { get; }
        
        Value<string> ProductOrServiceId5 { get; }
        
        Value<string> ProductOrServiceIdQualifier6 { get; }
        
        Value<string> ProductOrServiceId6 { get; }
        
        Value<string> ProductOrServiceIdQualifier7 { get; }
        
        Value<string> ProductOrServiceId7 { get; }
        
        Value<string> ProductOrServiceIdQualifier8 { get; }
        
        Value<string> ProductOrServiceId8 { get; }
        
        Value<string> ProductOrServiceIdQualifier9 { get; }
        
        Value<string> ProductOrServiceId9 { get; }
        
        Value<string> ProductOrServiceIdQualifier10 { get; }
        
        Value<string> ProductOrServiceId10 { get; }
    }
}