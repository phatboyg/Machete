namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CAS :
        X12Segment
    {
        Value<string> ClaimAdjustmentGroupCode { get; }

        Value<string> AdjustmentReasonCode1 { get; }

        Value<decimal> AdjustmentAmount1 { get; }

        Value<decimal> Quantity1 { get; }

        Value<string> AdjustmentReasonCode2 { get; }

        Value<decimal> AdjustmentAmount2 { get; }

        Value<decimal> Quantity2 { get; }

        Value<string> AdjustmentReasonCode3 { get; }

        Value<decimal> AdjustmentAmount3 { get; }

        Value<decimal> Quantity3 { get; }

        Value<string> AdjustmentReasonCode4 { get; }

        Value<decimal> AdjustmentAmount4 { get; }

        Value<decimal> Quantity4 { get; }

        Value<string> AdjustmentReasonCode5 { get; }

        Value<decimal> AdjustmentAmount5 { get; }

        Value<decimal> Quantity5 { get; }

        Value<string> AdjustmentReasonCode6 { get; }

        Value<decimal> AdjustmentAmount6 { get; }

        Value<decimal> Quantity6 { get; }
    }
}