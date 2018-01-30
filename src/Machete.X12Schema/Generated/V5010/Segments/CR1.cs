namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CR1 :
        X12Segment
    {
        Value<string> PatientWeightQualifier { get; }

        Value<decimal> PatientWeight { get; }

        Value<string> Code { get; }

        Value<string> ReasonCode { get; }

        Value<string> UnitForMeasurementCode { get; }

        Value<decimal> TransportDistance { get; }

        Value<string> RoundTripPurposeDescription { get; }

        Value<string> StretcherPurposeDescription { get; }
    }
}