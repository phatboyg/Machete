namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface DateTimeOffsetSegment :
        HL7Segment
    {
        Value<DateTimeOffset> TestDateTimeOffset { get; }
        Value<DateTimeOffset> TestDateTimeOffsetWithTime { get; }
    }
}