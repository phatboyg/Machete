namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface DRComponent :
        HL7Component
    {
        Value<DateTimeOffset> RangeStartDateTime { get; }
        Value<DateTimeOffset> RangeEndDateTime { get; }
    }
}