// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// OM1 (Segment) - General Segment
    /// </summary>
    public interface OM1 :
        HL7V26Segment
    {
        /// <summary>
        /// OM1-1: Sequence Number - Test/Observation Master File
        /// </summary>
        Value<decimal> SequenceNumberTestObservationMasterFile { get; }

        /// <summary>
        /// OM1-2: Producer's Service/Test/Observation ID
        /// </summary>
        Value<CWE> ProducerSServiceTestObservationId { get; }

        /// <summary>
        /// OM1-3: Permitted Data Types
        /// </summary>
        ValueList<string> PermittedDataTypes { get; }

        /// <summary>
        /// OM1-4: Specimen Required
        /// </summary>
        Value<string> SpecimenRequired { get; }

        /// <summary>
        /// OM1-5: Producer ID
        /// </summary>
        Value<CWE> ProducerId { get; }

        /// <summary>
        /// OM1-6: Observation Description
        /// </summary>
        Value<TX> ObservationDescription { get; }

        /// <summary>
        /// OM1-7: Other Service/Test/Observation IDs for the Observation
        /// </summary>
        Value<CWE> OtherServiceTestObservationIdsForObservation { get; }

        /// <summary>
        /// OM1-8: Other Names
        /// </summary>
        ValueList<string> OtherNames { get; }

        /// <summary>
        /// OM1-9: Preferred Report Name for the Observation
        /// </summary>
        Value<string> PreferredReportNameForObservation { get; }

        /// <summary>
        /// OM1-10: Preferred Short Name or Mnemonic for Observation
        /// </summary>
        Value<string> PreferredShortNameOrMnemonicForObservation { get; }

        /// <summary>
        /// OM1-11: Preferred Long Name for the Observation
        /// </summary>
        Value<string> PreferredLongNameForObservation { get; }

        /// <summary>
        /// OM1-12: Orderability
        /// </summary>
        Value<string> Orderability { get; }

        /// <summary>
        /// OM1-13: Identity of Instrument Used to Perform this Study
        /// </summary>
        ValueList<CWE> IdentityOfInstrumentUsedToPerformThisStudy { get; }

        /// <summary>
        /// OM1-14: Coded Representation of Method
        /// </summary>
        ValueList<CWE> CodedRepresentationOfMethod { get; }

        /// <summary>
        /// OM1-15: Portable Device Indicator
        /// </summary>
        Value<string> PortableDeviceIndicator { get; }

        /// <summary>
        /// OM1-16: Observation Producing Department/Section
        /// </summary>
        ValueList<CWE> ObservationProducingDepartmentSection { get; }

        /// <summary>
        /// OM1-17: Telephone Number of Section
        /// </summary>
        Value<XTN> TelephoneNumberOfSection { get; }

        /// <summary>
        /// OM1-18: Nature of Service/Test/Observation
        /// </summary>
        Value<string> NatureOfServiceTestObservation { get; }

        /// <summary>
        /// OM1-19: Report Subheader
        /// </summary>
        Value<CWE> ReportSubheader { get; }

        /// <summary>
        /// OM1-20: Report Display Order
        /// </summary>
        Value<string> ReportDisplayOrder { get; }

        /// <summary>
        /// OM1-21: Date/Time Stamp for any change in Definition for the Observation
        /// </summary>
        Value<DateTimeOffset> DateTimeStampForAnyChangeInDefinitionForObservation { get; }

        /// <summary>
        /// OM1-22: Effective Date/Time of Change
        /// </summary>
        Value<DateTimeOffset> EffectiveDateTimeOfChange { get; }

        /// <summary>
        /// OM1-23: Typical Turn-Around Time
        /// </summary>
        Value<decimal> TypicalTurnAroundTime { get; }

        /// <summary>
        /// OM1-24: Processing Time
        /// </summary>
        Value<decimal> ProcessingTime { get; }

        /// <summary>
        /// OM1-25: Processing Priority
        /// </summary>
        ValueList<string> ProcessingPriority { get; }

        /// <summary>
        /// OM1-26: Reporting Priority
        /// </summary>
        Value<string> ReportingPriority { get; }

        /// <summary>
        /// OM1-27: Outside Site(s) Where Observation may be Performed
        /// </summary>
        ValueList<CWE> OutsideSiteSWhereObservationMayBePerformed { get; }

        /// <summary>
        /// OM1-28: Address of Outside Site(s)
        /// </summary>
        ValueList<XAD> AddressOfOutsideSiteS { get; }

        /// <summary>
        /// OM1-29: Phone Number of Outside Site
        /// </summary>
        Value<XTN> PhoneNumberOfOutsideSite { get; }

        /// <summary>
        /// OM1-30: Confidentiality Code
        /// </summary>
        Value<CWE> ConfidentialityCode { get; }

        /// <summary>
        /// OM1-31: Observations Required to Interpret the Observation
        /// </summary>
        Value<CWE> ObservationsRequiredToInterpretObservation { get; }

        /// <summary>
        /// OM1-32: Interpretation of Observations
        /// </summary>
        Value<TX> InterpretationOfObservations { get; }

        /// <summary>
        /// OM1-33: Contraindications to Observations
        /// </summary>
        Value<CWE> ContraindicationToObservations { get; }

        /// <summary>
        /// OM1-34: Reflex Tests/Observations
        /// </summary>
        ValueList<CWE> ReflexTestsObservations { get; }

        /// <summary>
        /// OM1-35: Rules that Trigger Reflex Testing
        /// </summary>
        Value<TX> RuleThatTriggerReflexTesting { get; }

        /// <summary>
        /// OM1-36: Fixed Canned Message
        /// </summary>
        Value<CWE> FixedCannedMessage { get; }

        /// <summary>
        /// OM1-37: Patient Preparation
        /// </summary>
        Value<TX> PatientPreparation { get; }

        /// <summary>
        /// OM1-38: Procedure Medication
        /// </summary>
        Value<CWE> ProcedureMedication { get; }

        /// <summary>
        /// OM1-39: Factors that may Affect the Observation
        /// </summary>
        Value<TX> FactorsThatMayAffectObservation { get; }

        /// <summary>
        /// OM1-40: Service/Test/Observation Performance Schedule
        /// </summary>
        ValueList<string> ServiceTestObservationPerformanceSchedule { get; }

        /// <summary>
        /// OM1-41: Description of Test Methods
        /// </summary>
        Value<TX> DescriptionOfTestMethods { get; }

        /// <summary>
        /// OM1-42: Kind of Quantity Observed
        /// </summary>
        Value<CWE> KindOfQuantityObserved { get; }

        /// <summary>
        /// OM1-43: Point Versus Interval
        /// </summary>
        Value<CWE> PointVersusInterval { get; }

        /// <summary>
        /// OM1-44: Challenge Information
        /// </summary>
        Value<TX> ChallengeInformation { get; }

        /// <summary>
        /// OM1-45: Relationship Modifier
        /// </summary>
        Value<CWE> RelationshipModifier { get; }

        /// <summary>
        /// OM1-46: Target Anatomic Site Of Test
        /// </summary>
        Value<CWE> TargetAnatomicSiteOfTest { get; }

        /// <summary>
        /// OM1-47: Modality Of Imaging Measurement
        /// </summary>
        Value<CWE> ModalityOfImagingMeasurement { get; }
    }
}