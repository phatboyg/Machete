namespace Machete.X12Schema.V5010.Segments
{
    using System;
    using X12;


    public interface DAD :
        X12Segment
    {
        Value<string> ActionCode { get; }

        Value<string> TransactionHandlingCode { get; }

        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> OriginatingCompanyIdentifier { get; }
        
        Value<string> OriginatingCompanySupplementalCode { get; }
        
        Value<string> AmountQualifierCode { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> ReferenceIdentification1 { get; }
        
        Value<string> ReferenceIdentification2 { get; }
        
        Value<string> DepositoryFinancialInstitutionIdentificationNumberQualifier { get; }
        
        Value<string> DepositoryFinancialInstitutionIdentificationNumber { get; }
        
        Value<string> AccountNumber { get; }
        
        Value<decimal> Number { get; }
        
        Value<string> FrequencyCode { get; }
    }
}