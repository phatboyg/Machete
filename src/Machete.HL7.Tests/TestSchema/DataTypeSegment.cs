namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface DataTypeSegment :
        HL7Segment
    {
        Value<bool> BooleanField { get; }
        Value<decimal> DecimalField { get; }
        Value<int> IntegerField { get; }
        Value<DateTime> DateTimeField { get; }
        Value<DateTimeOffset> DateTimeOffsetField { get; }
        Value<long> LongField { get; }
        Value<Guid> GuidField { get; }
        Value<FT> FTField { get; }
        Value<TX> TXField { get; }
    }
}