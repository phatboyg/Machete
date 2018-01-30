namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CN1 :
        X12Segment
    {
        Value<string> ContractTypeCode { get; }

        Value<decimal> ContractAmount { get; }

        Value<decimal> ContractPercentage { get; }

        Value<string> ContractCode { get; }

        Value<decimal> TermsDiscountPercentage { get; }

        Value<string> ContractVersionIdentifier { get; }
    }
}