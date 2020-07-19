// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// IPC (Segment) - Imaging Procedure Control Segment
    /// </summary>
    public interface IPC :
        HL7V26Segment
    {
        /// <summary>
        /// IPC-1: Accession Identifier
        /// </summary>
        Value<EI> AccessionIdentifier { get; }

        /// <summary>
        /// IPC-2: Requested Procedure ID
        /// </summary>
        Value<EI> RequestedProcedureId { get; }

        /// <summary>
        /// IPC-3: Study Instance UID
        /// </summary>
        Value<EI> StudyInstanceUId { get; }

        /// <summary>
        /// IPC-4: Scheduled Procedure Step ID
        /// </summary>
        Value<EI> ScheduledProcedureStepId { get; }

        /// <summary>
        /// IPC-5: Modality
        /// </summary>
        Value<CWE> Modality { get; }

        /// <summary>
        /// IPC-6: Protocol Code
        /// </summary>
        ValueList<CWE> ProtocolCode { get; }

        /// <summary>
        /// IPC-7: Scheduled Station Name
        /// </summary>
        Value<EI> ScheduledStationName { get; }

        /// <summary>
        /// IPC-8: Scheduled Procedure Step Location
        /// </summary>
        ValueList<CWE> ScheduledProcedureStepLocation { get; }

        /// <summary>
        /// IPC-9: Scheduled Station AE Title
        /// </summary>
        Value<string> ScheduledStationAETitle { get; }
    }
}