namespace Machete.HL7.Tests.Segments
{
    using System;

    public interface DateTimeSegment :
        HL7Segment
    {
        Value<DateTimeOffset> TestDateTimeOffset { get; }
        Value<DateTimeOffset> TestDateTimeOffsetWithTime { get; }
    }
}