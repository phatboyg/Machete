namespace Machete.X12Schema.V5010
{
    using X12;


    public interface DIS :
        X12Segment
    {
        Value<string> DiscountTermsTypeCode { get; }
        
        Value<string> DiscountBaseQualifier { get; }
        
        Value<string> DiscountBaseValue { get; }
        
        Value<int> DiscountControlLimitQualifier { get; }
        
        Value<int> DiscountControlLimit1 { get; }
        
        Value<int> DiscountControlLimit2 { get; }
    }
}