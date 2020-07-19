// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OM1 (SegmentMap) - General Segment
    /// </summary>
    public class OM1Map :
        HL7V26SegmentMap<OM1>
    {
        public OM1Map()
        {
            Id = "OM1";

            Name = "General Segment";

            Value(x => x.SequenceNumberTestObservationMasterFile, 1, x => x.IsRequired());
            Entity(x => x.ProducerSServiceTestObservationId, 2, x => x.IsRequired());
            Value(x => x.PermittedDataTypes, 3);
            Value(x => x.SpecimenRequired, 4, x => x.IsRequired());
            Entity(x => x.ProducerId, 5, x => x.IsRequired());
            Value(x => x.ObservationDescription, 6);
            Entity(x => x.OtherServiceTestObservationIdsForObservation, 7);
            Value(x => x.OtherNames, 8, x => x.IsRequired());
            Value(x => x.PreferredReportNameForObservation, 9);
            Value(x => x.PreferredShortNameOrMnemonicForObservation, 10);
            Value(x => x.PreferredLongNameForObservation, 11);
            Value(x => x.Orderability, 12);
            Entity(x => x.IdentityOfInstrumentUsedToPerformThisStudy, 13);
            Entity(x => x.CodedRepresentationOfMethod, 14);
            Value(x => x.PortableDeviceIndicator, 15);
            Entity(x => x.ObservationProducingDepartmentSection, 16);
            Entity(x => x.TelephoneNumberOfSection, 17);
            Value(x => x.NatureOfServiceTestObservation, 18, x => x.IsRequired());
            Entity(x => x.ReportSubheader, 19);
            Value(x => x.ReportDisplayOrder, 20);
            Value(x => x.DateTimeStampForAnyChangeInDefinitionForObservation, 21, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EffectiveDateTimeOfChange, 22, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.TypicalTurnAroundTime, 23);
            Value(x => x.ProcessingTime, 24);
            Value(x => x.ProcessingPriority, 25);
            Value(x => x.ReportingPriority, 26);
            Entity(x => x.OutsideSiteSWhereObservationMayBePerformed, 27);
            Entity(x => x.AddressOfOutsideSiteS, 28);
            Entity(x => x.PhoneNumberOfOutsideSite, 29);
            Entity(x => x.ConfidentialityCode, 30);
            Entity(x => x.ObservationsRequiredToInterpretObservation, 31);
            Value(x => x.InterpretationOfObservations, 32);
            Entity(x => x.ContraindicationToObservations, 33);
            Entity(x => x.ReflexTestsObservations, 34);
            Value(x => x.RuleThatTriggerReflexTesting, 35);
            Entity(x => x.FixedCannedMessage, 36);
            Value(x => x.PatientPreparation, 37);
            Entity(x => x.ProcedureMedication, 38);
            Value(x => x.FactorsThatMayAffectObservation, 39);
            Value(x => x.ServiceTestObservationPerformanceSchedule, 40);
            Value(x => x.DescriptionOfTestMethods, 41);
            Entity(x => x.KindOfQuantityObserved, 42);
            Entity(x => x.PointVersusInterval, 43);
            Value(x => x.ChallengeInformation, 44);
            Entity(x => x.RelationshipModifier, 45);
            Entity(x => x.TargetAnatomicSiteOfTest, 46);
            Entity(x => x.ModalityOfImagingMeasurement, 47);
        }
    }
}