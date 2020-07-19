// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OBX (SegmentMap) - Observation/Result
    /// </summary>
    public class OBXMap :
        HL7V26SegmentMap<OBX>
    {
        public OBXMap()
        {
            Id = "OBX";

            Name = "Observation/Result";

            Value(x => x.SetId, 1);
            Value(x => x.ValueType, 2);
            Entity(x => x.ObservationIdentifier, 3, x => x.IsRequired());
            Value(x => x.ObservationSubId, 4);
            Value(x => x.ObservationValue, 5);
            Entity(x => x.Units, 6);
            Value(x => x.ReferenceRange, 7);
            Value(x => x.AbnormalFlags, 8);
            Value(x => x.Probability, 9);
            Value(x => x.NatureOfAbnormalTest, 10);
            Value(x => x.ObservationResultStatus, 11, x => x.IsRequired());
            Value(x => x.EffectiveDateOfReferenceRange, 12, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.UserDefinedAccessChecks, 13);
            Value(x => x.DateTimeOfObservation, 14, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ProducerSId, 15);
            Entity(x => x.ResponsibleObserver, 16);
            Entity(x => x.ObservationMethod, 17);
            Entity(x => x.EquipmentInstanceIdentifier, 18);
            Value(x => x.DateTimeOfAnalysis, 19, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ObservationSite, 20);
            Entity(x => x.ObservationInstanceIdentifier, 21);
            Entity(x => x.MoodCode, 22);
            Entity(x => x.PerformingOrganizationName, 23);
            Entity(x => x.PerformingOrganizationAddress, 24);
            Entity(x => x.PerformingOrganizationMedicalDirector, 25);
        }
    }
}