namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PDD :
        X12Segment
    {
        Value<string> AssignedIdentification { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<decimal> PercentageAsDecimal { get; }
        
        Value<string> ProposalDataDetailIdentifierCode { get; }
    }
}