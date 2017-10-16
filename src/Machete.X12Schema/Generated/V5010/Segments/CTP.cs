namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CTP : X12Segment
    {
        Value<decimal> DrugUnitPrice { get; }

        Value<decimal> Quantity { get; }

        Value<string> UnitForMeasurementCode { get; }
    }
}