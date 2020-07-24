namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PEN :
        X12Segment
    {
        Value<string> TransactionTypeCode { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> ContributionCode { get; }
        
        Value<string> Percent { get; }
        
        Value<string> SpecialProcessingType { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<decimal> Number { get; }
        
        Value<string> LoanTypeCode { get; }
        
        Value<string> MaintenanceTypeCode { get; }
    }
}