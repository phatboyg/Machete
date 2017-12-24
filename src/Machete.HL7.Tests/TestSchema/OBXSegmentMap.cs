namespace Machete.HL7.Tests.TestSchema
{
    public class OBXSegmentMap :
        HL7SegmentMap<OBXSegment, HL7Entity>
    {
        public OBXSegmentMap()
        {
            Id = "OBX";

            Name = "Observation/Result";

            Value(x => x.SetId, 1);
            Value(x => x.ValueType, 2);
            Entity(x => x.ObservationIdentifier, 3, x => {x.Required = true;});
            Value(x => x.ObservationSubId, 4);
            Value(x => x.ObservationValue, 5);
            Entity(x => x.Units, 6);
            Value(x => x.ReferenceRange, 7);
            Value(x => x.AbnormalFlags, 8);
            Value(x => x.Probability, 9);
            Value(x => x.NatureOfAbnormalTest, 10);
            Value(x => x.ObservationResultStatus, 11, x => {x.Required = true;});
            Value(x => x.EffectiveDateOfReferenceRange, 12, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.UserDefinedAccessChecks, 13);
            Value(x => x.DateTimeOfObservation, 14, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.ProducerSId, 15);
        }
    }
}