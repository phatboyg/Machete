// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// OBR (Segment) - Observation Request
    /// </summary>
    public interface OBR :
        HL7V26Segment
    {
        /// <summary>
        /// OBR-1: Set ID - OBR
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// OBR-2: Placer Order Number
        /// </summary>
        Value<EI> PlacerOrderNumber { get; }

        /// <summary>
        /// OBR-3: Filler Order Number
        /// </summary>
        Value<EI> FillerOrderNumber { get; }

        /// <summary>
        /// OBR-4: Universal Service Identifier
        /// </summary>
        Value<CWE> UniversalServiceIdentifier { get; }

        /// <summary>
        /// OBR-5: Priority
        /// </summary>
        Value<string> Priority { get; }

        /// <summary>
        /// OBR-6: Requested Date/Time
        /// </summary>
        Value<DateTimeOffset> RequestedDateTime { get; }

        /// <summary>
        /// OBR-7: Observation Date/Time #
        /// </summary>
        Value<DateTimeOffset> ObservationDateTime { get; }

        /// <summary>
        /// OBR-8: Observation End Date/Time #
        /// </summary>
        Value<DateTimeOffset> ObservationEndDateTime { get; }

        /// <summary>
        /// OBR-9: Collection Volume *
        /// </summary>
        Value<CQ> CollectionVolume { get; }

        /// <summary>
        /// OBR-10: Collector Identifier *
        /// </summary>
        ValueList<XCN> CollectorIdentifier { get; }

        /// <summary>
        /// OBR-11: Specimen Action Code *
        /// </summary>
        Value<string> SpecimenActionCode { get; }

        /// <summary>
        /// OBR-12: Danger Code
        /// </summary>
        Value<CWE> DangerCode { get; }

        /// <summary>
        /// OBR-13: Relevant Clinical Information
        /// </summary>
        Value<string> RelevantClinicalInformation { get; }

        /// <summary>
        /// OBR-14: Specimen Received Date/Time
        /// </summary>
        Value<DateTimeOffset> SpecimenReceivedDateTime { get; }

        /// <summary>
        /// OBR-15: Specimen Source
        /// </summary>
        Value<SPS> SpecimenSource { get; }

        /// <summary>
        /// OBR-16: Ordering Provider
        /// </summary>
        ValueList<XCN> OrderingProvider { get; }

        /// <summary>
        /// OBR-17: Order Callback Phone Number
        /// </summary>
        Value<XTN> OrderCallbackPhoneNumber { get; }

        /// <summary>
        /// OBR-18: Placer Field 1
        /// </summary>
        Value<string> PlacerField1 { get; }

        /// <summary>
        /// OBR-19: Placer Field 2
        /// </summary>
        Value<string> PlacerField2 { get; }

        /// <summary>
        /// OBR-20: Filler Field 1 +
        /// </summary>
        Value<string> FillerField1 { get; }

        /// <summary>
        /// OBR-21: Filler Field 2 +
        /// </summary>
        Value<string> FillerField2 { get; }

        /// <summary>
        /// OBR-22: Results Reported/Status Change - Date/Time +
        /// </summary>
        Value<DateTimeOffset> ResultReportedStatusChangeDateTime { get; }

        /// <summary>
        /// OBR-23: Charge to Practice +
        /// </summary>
        Value<MOC> ChargeToPractice { get; }

        /// <summary>
        /// OBR-24: Diagnostic Serv Sect ID
        /// </summary>
        Value<string> DiagnosticServiceSectionId { get; }

        /// <summary>
        /// OBR-25: Result Status +
        /// </summary>
        Value<string> ResultStatus { get; }

        /// <summary>
        /// OBR-26: Parent Result +
        /// </summary>
        Value<PRL> ParentResult { get; }

        /// <summary>
        /// OBR-27: Quantity/Timing
        /// </summary>
        ValueList<TQ> QuantityTiming { get; }

        /// <summary>
        /// OBR-28: Result Copies To
        /// </summary>
        ValueList<XCN> ResultCopiesTo { get; }

        /// <summary>
        /// OBR-29: Parent
        /// </summary>
        Value<EIP> Parent { get; }

        /// <summary>
        /// OBR-30: Transportation Mode
        /// </summary>
        Value<string> TransportationMode { get; }

        /// <summary>
        /// OBR-31: Reason for Study
        /// </summary>
        ValueList<CWE> ReasonForStudy { get; }

        /// <summary>
        /// OBR-32: Principal Result Interpreter +
        /// </summary>
        Value<NDL> PrincipalResultInterpreter { get; }

        /// <summary>
        /// OBR-33: Assistant Result Interpreter +
        /// </summary>
        ValueList<NDL> AssistantResultInterpreter { get; }

        /// <summary>
        /// OBR-34: Technician +
        /// </summary>
        ValueList<NDL> Technician { get; }

        /// <summary>
        /// OBR-35: Transcriptionist +
        /// </summary>
        ValueList<NDL> Transcriptionist { get; }

        /// <summary>
        /// OBR-36: Scheduled Date/Time +
        /// </summary>
        Value<DateTimeOffset> ScheduledDateTime { get; }

        /// <summary>
        /// OBR-37: Number of Sample Containers *
        /// </summary>
        Value<decimal> NumberOfSampleContainers { get; }

        /// <summary>
        /// OBR-38: Transport Logistics of Collected Sample *
        /// </summary>
        ValueList<CWE> TransportLogisticsOfCollectedSample { get; }

        /// <summary>
        /// OBR-39: Collector's Comment *
        /// </summary>
        ValueList<CWE> CollectorSComment { get; }

        /// <summary>
        /// OBR-40: Transport Arrangement Responsibility
        /// </summary>
        Value<CWE> TransportArrangementResponsibility { get; }

        /// <summary>
        /// OBR-41: Transport Arranged
        /// </summary>
        Value<string> TransportArranged { get; }

        /// <summary>
        /// OBR-42: Escort Required
        /// </summary>
        Value<string> EscortRequired { get; }

        /// <summary>
        /// OBR-43: Planned Patient Transport Comment
        /// </summary>
        ValueList<CWE> PlannedPatientTransportComment { get; }

        /// <summary>
        /// OBR-44: Procedure Code
        /// </summary>
        Value<CNE> ProcedureCode { get; }

        /// <summary>
        /// OBR-45: Procedure Code Modifier
        /// </summary>
        ValueList<CNE> ProcedureCodeModifier { get; }

        /// <summary>
        /// OBR-46: Placer Supplemental Service Information
        /// </summary>
        ValueList<CWE> PlacerSupplementalServiceInformation { get; }

        /// <summary>
        /// OBR-47: Filler Supplemental Service Information
        /// </summary>
        ValueList<CWE> FillerSupplementalServiceInformation { get; }

        /// <summary>
        /// OBR-48: Medically Necessary Duplicate Procedure Reason
        /// </summary>
        Value<CWE> MedicallyNecessaryDuplicateProcedureReason { get; }

        /// <summary>
        /// OBR-49: Result Handling
        /// </summary>
        Value<string> ResultHandling { get; }

        /// <summary>
        /// OBR-50: Parent Universal Service Identifier
        /// </summary>
        Value<CWE> ParentUniversalServiceIdentifier { get; }
    }
}