namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface DTP : X12Segment
    {
        Value<string> Qualifier { get; }

        Value<string> FormatQualifier { get; }

        // TODO qualifier 2
        Value<DateTimePeriod> Period { get; }
    }
}