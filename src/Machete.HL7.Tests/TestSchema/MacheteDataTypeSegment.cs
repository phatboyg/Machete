namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface MacheteDataTypeSegment :
        HL7Segment
    {
        Value<string> StringField { get; }
        Value<int> IntField { get; }
        Value<long> LongField { get; }
        Value<decimal> DecimalField { get; }
        Value<Guid> GuidField { get; }
        Value<DateTimeOffset> DateTimeOffsetField { get; }
        Value<short> ShortField { get; }
        Value<bool> BooleanField { get; }
        Value<DateTime> DateTimeField { get; }
        Value<byte> ByteField { get; }
        Value<FT> FTField { get; }
        Value<TX> TXField { get; }
        ValueList<string> StringListField { get; }
        ValueList<int> IntListField { get; }
        ValueList<long> LongListField { get; }
        ValueList<Guid> GuidListField { get; }
        ValueList<DateTimeOffset> DateTimeOffsetListField { get; }
        ValueList<short> ShortListField { get; }
        ValueList<bool> BooleanListField { get; }
        ValueList<DateTime> DateTimeListField { get; }
        ValueList<byte> ByteListField { get; }
        ValueList<FT> FTListField { get; }
        ValueList<TX> TXListField { get; }
    }
}