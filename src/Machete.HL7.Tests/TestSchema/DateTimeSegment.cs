namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface DateTimeSegment :
        HL7Segment
    {
        Value<DateTime> TestDateTime { get; }
    }
}