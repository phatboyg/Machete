namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface BAU :
        X12Segment
    {
        Value<string> ReferenceIdentification { get; }
        
        Value<string> PaymentMethodCode { get; }
        
        Value<string> DepositoryFinancialInstitutionIdentificationNumberQualifier { get; }
        
        Value<string> DepositoryFinancialInstitutionIdentificationNumber { get; }
        
        Value<string> AccountNumber { get; }
        
        Value<string> Name { get; }
    }
}