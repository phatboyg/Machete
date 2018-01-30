namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface DTP :
        X12Segment
    {
        Value<string> DateTimeQualifier { get; }

        Value<string> DateTimePeriodFormatQualifier { get; }

        Value<DateTimePeriod> DateTimePeriod { get; }
    }
}