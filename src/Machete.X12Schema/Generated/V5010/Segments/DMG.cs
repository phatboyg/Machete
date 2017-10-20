namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface DMG : X12Segment
    {
        Value<string> DateTimeFormatQualifier { get; }

        // TODO qualifier 1
        Value<DateTimePeriod> Period { get; }

        Value<string> GenderCode { get; }
    }
}