namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TXI :
        X12Segment
    {
        Value<string> TaxTypeCode { get; }
        
        Value<decimal> PercentageAsDecimal { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> TaxJurisdictionCodeQualifier { get; }
        
        Value<string> TaxJurisdictionCode { get; }
        
        Value<string> TaxExemptCode { get; }
        
        Value<string> RelationshipCode { get; }
        
        Value<string> DollarBasisForPercent { get; }
        
        Value<string> TaxIdentificationNumber { get; }
        
        Value<string> AssignedIdentification { get; }
    }
}