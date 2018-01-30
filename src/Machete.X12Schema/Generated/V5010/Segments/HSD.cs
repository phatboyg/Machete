namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface HSD :
        X12Segment
    {
        Value<string> QuantityQualifier { get; }

        // TODO qualifier 1
        Value<decimal> Quantity { get; }

        Value<string> UnitBasisforMeasurementCode { get; }

        Value<decimal> SampleSelectionModulus { get; }

        Value<string> TimePeriodQualifier { get; }

        // TODO qualifier 5
        Value<int> Periods { get; }

        Value<string> ShipDeliveryCalendarPatternCode { get; }

        Value<string> ShipDeliveryPatternTimeCode { get; }
    }
}