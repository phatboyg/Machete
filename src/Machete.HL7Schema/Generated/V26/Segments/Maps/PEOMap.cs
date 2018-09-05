// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEO (SegmentMap) - Product Experience Observation
    /// </summary>
    public class PEOMap :
        HL7V26SegmentMap<PEO>
    {
        public PEOMap()
        {
            Id = "PEO";

            Name = "Product Experience Observation";

            Entity(x => x.EventIdentifiersUsed, 1);
            Entity(x => x.EventSymptomDiagnosisCode, 2);
            Value(x => x.EventOnsetDateTime, 3, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Value(x => x.EventExacerbationDateTime, 4, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EventImprovedDateTime, 5, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EventEndedDataTime, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.EventLocationOccurredAddress, 7);
            Value(x => x.EventQualification, 8);
            Value(x => x.EventSerious, 9);
            Value(x => x.EventExpected, 10);
            Value(x => x.EventOutcome, 11);
            Value(x => x.PatientOutcome, 12);
            Value(x => x.EventDescriptionFromOthers, 13);
            Value(x => x.EventDescriptionFromOriginalReporter, 14);
            Value(x => x.EventDescriptionFromPatient, 15);
            Value(x => x.EventDescriptionFromPractitioner, 16);
            Value(x => x.EventDescriptionFromAutopsy, 17);
            Entity(x => x.CauseOfDeath, 18);
            Entity(x => x.PrimaryObserverName, 19);
            Entity(x => x.PrimaryObserverAddress, 20);
            Entity(x => x.PrimaryObserverTelephone, 21);
            Value(x => x.PrimaryObserverSQualification, 22);
            Value(x => x.ConfirmationProvidedBy, 23);
            Value(x => x.PrimaryObserverAwareDateTime, 24, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.PrimaryObserverSIdentityMayBeDivulged, 25);
        }
    }
}