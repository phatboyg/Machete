namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface MEA : X12Segment
    {
        Value<string> ReferenceIdentificationCode { get; }

        Value<string> MeasurementQualifier { get; }

        // TODO qualifier 2
        Value<decimal> MeasurementValue { get; }
    }
}