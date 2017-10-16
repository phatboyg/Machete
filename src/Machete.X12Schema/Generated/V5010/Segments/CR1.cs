namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CR1 : X12Segment
    {
        Value<string> PatientWeightQualifier { get; }

        // TODO qualifier 1
        Value<decimal> PatientWeight { get; }

        Value<string> Code { get; }

        Value<string> ReasonCode { get; }

        Value<string> DistanceQualifier { get; }

        // TODO qualifier 5
        Value<decimal> Distance { get; }

        Value<string> RoundTripPurpose { get; }

        Value<string> StretcherPurpose { get; }
    }
}