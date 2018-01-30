namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface DMG :
        X12Segment
    {
        Value<string> DateTimeFormatQualifier { get; }

        Value<DateTimePeriod> DateOfBirth { get; }

        Value<string> GenderCode { get; }
    }
}