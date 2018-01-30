namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface SVC :
        X12Segment
    {
        Value<string> SVC01 { get; }

        Value<decimal> LineItemCharge { get; }

        Value<decimal> LineItemPayment { get; }

        Value<string> RevenueCode { get; }

        Value<decimal> UnitsOfServicePaidCount { get; }

        Value<string> SVC06 { get; }

        Value<decimal> OriginalUnitsOfService { get; }
    }
}