namespace Machete.HL7.Tests.TestSchema
{
    public class DataTypeSegmentMap :
        HL7SegmentMap<DataTypeSegment, HL7Entity>
    {
        public DataTypeSegmentMap()
        {
            Id = "DT1";

            Name = "Diagnosis";

            Value(x => x.BooleanField, 1, x => x.IsRequired());
            Value(x => x.DecimalField, 2, x => x.IsOptional());
            Value(x => x.IntegerField, 3, x => x.IsOptional());
            Value(x => x.DateTimeField, 4, x =>
            {
                x.Converter = HL7ValueConverters.VariableShortDateTime;
                x.MaxLength = 26;
            });
            Value(x => x.DateTimeOffsetField, 5, x =>
            {
                x.Converter = HL7ValueConverters.VariableLongDateTime;
                x.MaxLength = 26;
            });
            Value(x => x.LongField, 6, x => x.IsOptional());
            Value(x => x.GuidField, 7, x => x.IsOptional());
            Value(x => x.FTField, 8, x => x.IsOptional());
            Value(x => x.TXField, 9, x => x.IsOptional());
        }
    }
}