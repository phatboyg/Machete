namespace Machete.HL7.Tests.TestSchema
{
    public class MacheteDataTypeSegmentMap :
        HL7SegmentMap<MacheteDataTypeSegment, HL7Segment>
    {
        public MacheteDataTypeSegmentMap()
        {
            Id = "MDT";

            Value(x => x.StringField, 1);
            Value(x => x.IntField, 2);
            Value(x => x.LongField, 3);
            Value(x => x.DecimalField, 4);
            Value(x => x.GuidField, 5);
            Value(x => x.DateTimeOffsetField, 6, x => { x.Converter = HL7ValueConverters.VariableLongDateTime; x.MaxLength = 10; });
            Value(x => x.ShortField, 7);
            Value(x => x.BooleanField, 8);
            Value(x => x.DateTimeField, 9, x => { x.Converter = HL7ValueConverters.VariableShortDateTime; x.MaxLength = 10; });
            Value(x => x.ByteField, 10);
            Value(x => x.FTField, 11);
            Value(x => x.TXField, 12);
            Value(x => x.StringListField, 13);
            Value(x => x.IntListField, 14);
            Value(x => x.LongListField, 15);
            Value(x => x.GuidListField, 16);
            Value(x => x.DateTimeOffsetListField, 17, x => { x.Converter = HL7ValueConverters.VariableLongDateTime; x.MaxLength = 10; });
            Value(x => x.ShortListField, 18);
            Value(x => x.BooleanListField, 19);
            Value(x => x.DateTimeListField, 20, x => { x.Converter = HL7ValueConverters.VariableShortDateTime; x.MaxLength = 10; });
            Value(x => x.ByteListField, 21);
            Value(x => x.FTListField, 22);
            Value(x => x.TXListField, 23);
        }
    }
}