// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// IPC (SegmentMap) - Imaging Procedure Control Segment
    /// </summary>
    public class IPCMap :
        HL7V26SegmentMap<IPC>
    {
        public IPCMap()
        {
            Id = "IPC";

            Name = "Imaging Procedure Control Segment";

            Entity(x => x.AccessionIdentifier, 1, x => x.IsRequired());
            Entity(x => x.RequestedProcedureId, 2, x => x.IsRequired());
            Entity(x => x.StudyInstanceUId, 3, x => x.IsRequired());
            Entity(x => x.ScheduledProcedureStepId, 4, x => x.IsRequired());
            Entity(x => x.Modality, 5);
            Entity(x => x.ProtocolCode, 6);
            Entity(x => x.ScheduledStationName, 7);
            Entity(x => x.ScheduledProcedureStepLocation, 8);
            Value(x => x.ScheduledStationAETitle, 9);
        }
    }
}