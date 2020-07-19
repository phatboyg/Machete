namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface BAL :
        X12Segment
    {
        Value<string> BalanceTypeCode { get; }
        
        Value<string> AmountQualifierCode { get; }
        
        Value<decimal> MonetaryAmount { get; }
    }
}