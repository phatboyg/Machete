// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OBR (SegmentMap) - Observation Request
    /// </summary>
    public class OBRMap :
        HL7V26SegmentMap<OBR>
    {
        public OBRMap()
        {
            Id = "OBR";

            Name = "Observation Request";

            Value(x => x.SetId, 1);
            Entity(x => x.PlacerOrderNumber, 2);
            Entity(x => x.FillerOrderNumber, 3);
            Entity(x => x.UniversalServiceIdentifier, 4, x => {x.Required = true;});
            Value(x => x.Priority, 5);
            Value(x => x.RequestedDateTime, 6, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ObservationDateTime, 7, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ObservationEndDateTime, 8, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.CollectionVolume, 9);
            Entity(x => x.CollectorIdentifier, 10);
            Value(x => x.SpecimenActionCode, 11);
            Entity(x => x.DangerCode, 12);
            Value(x => x.RelevantClinicalInformation, 13);
            Value(x => x.SpecimenReceivedDateTime, 14, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.SpecimenSource, 15);
            Entity(x => x.OrderingProvider, 16);
            Entity(x => x.OrderCallbackPhoneNumber, 17);
            Value(x => x.PlacerField1, 18);
            Value(x => x.PlacerField2, 19);
            Value(x => x.FillerField1, 20);
            Value(x => x.FillerField2, 21);
            Value(x => x.ResultReportedStatusChangeDateTime, 22, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.ChargeToPractice, 23);
            Value(x => x.DiagnosticServiceSectionId, 24);
            Value(x => x.ResultStatus, 25);
            Entity(x => x.ParentResult, 26);
            Entity(x => x.QuantityTiming, 27);
            Entity(x => x.ResultCopiesTo, 28);
            Entity(x => x.Parent, 29);
            Value(x => x.TransportationMode, 30);
            Entity(x => x.ReasonForStudy, 31);
            Entity(x => x.PrincipalResultInterpreter, 32);
            Entity(x => x.AssistantResultInterpreter, 33);
            Entity(x => x.Technician, 34);
            Entity(x => x.Transcriptionist, 35);
            Value(x => x.ScheduledDateTime, 36, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.NumberOfSampleContainers, 37);
            Entity(x => x.TransportLogisticsOfCollectedSample, 38);
            Entity(x => x.CollectorSComment, 39);
            Entity(x => x.TransportArrangementResponsibility, 40);
            Value(x => x.TransportArranged, 41);
            Value(x => x.EscortRequired, 42);
            Entity(x => x.PlannedPatientTransportComment, 43);
            Entity(x => x.ProcedureCode, 44);
            Entity(x => x.ProcedureCodeModifier, 45);
            Entity(x => x.PlacerSupplementalServiceInformation, 46);
            Entity(x => x.FillerSupplementalServiceInformation, 47);
            Entity(x => x.MedicallyNecessaryDuplicateProcedureReason, 48);
            Value(x => x.ResultHandling, 49);
            Entity(x => x.ParentUniversalServiceIdentifier, 50);
        }
    }
}