namespace Machete.HL7.Tests.TestSchema
{
    public class DG1SegmentMap :
        HL7SegmentMap<DG1Segment, HL7Entity>
    {
        public DG1SegmentMap()
        {
            Id = "DG1";

            Name = "Diagnosis";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Value(x => x.DiagnosiCodingMethod, 2, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.DiagnosiCode, 3, x => {x.Required = true;});
            Value(x => x.DiagnosiDescription, 4, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DiagnosiDateTime, 5, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DiagnosiType, 6, x => {x.Required = true;});
        }
    }
}