namespace Machete.HL7.Tests.TestSchema
{
    public class AL1SegmentMap :
        HL7SegmentMap<AL1Segment, HL7Entity>
    {
        public AL1SegmentMap()
        {
            Id = "AL1";

            Name = "Patient Allergy Information";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Entity(x => x.AllergenTypeCode, 2);
            Entity(x => x.AllergenCodeMnemonicDescription, 3, x => {x.Required = true;});
            Entity(x => x.AllergySeverityCode, 4);
            Value(x => x.AllergyReactionCode, 5);
            Value(x => x.IdentificationDate, 6, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
        }
    }
}