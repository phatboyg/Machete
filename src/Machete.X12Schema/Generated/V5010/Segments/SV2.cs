namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface SV2 :
        X12Segment
    {
        Value<string> ServiceLineRevenueCode { get; }

        Value<string> ServiceLineProcedureCode { get; }

        Value<decimal> LineItemChargeAmount { get; }

        Value<string> UnitForMeasurementCode { get; }

        Value<decimal> ServiceUnitCount { get; }

        Value<decimal> ServiceLineRate { get; }

        Value<decimal> NonCoveredChargeAmount { get; }
    }
}