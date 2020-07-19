// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SCH (SegmentMap) - Scheduling Activity Information
    /// </summary>
    public class SCHMap :
        HL7V26SegmentMap<SCH>
    {
        public SCHMap()
        {
            Id = "SCH";

            Name = "Scheduling Activity Information";

            Entity(x => x.PlacerAppointmentId, 1);
            Entity(x => x.FillerAppointmentId, 2);
            Value(x => x.OccurrenceNumber, 3);
            Entity(x => x.PlacerGroupNumber, 4);
            Entity(x => x.ScheduleId, 5);
            Entity(x => x.EventReason, 6, x => x.IsRequired());
            Entity(x => x.AppointmentReason, 7);
            Entity(x => x.AppointmentType, 8);
            Value(x => x.AppointmentDuration, 9);
            Entity(x => x.AppointmentDurationUnits, 10);
            Entity(x => x.AppointmentTimingQuantity, 11);
            Entity(x => x.PlacerContactPerson, 12);
            Entity(x => x.PlacerContactPhoneNumber, 13);
            Entity(x => x.PlacerContactAddress, 14);
            Entity(x => x.PlacerContactLocation, 15);
            Entity(x => x.FillerContactPerson, 16, x => x.IsRequired());
            Entity(x => x.FillerContactPhoneNumber, 17);
            Entity(x => x.FillerContactAddress, 18);
            Entity(x => x.FillerContactLocation, 19);
            Entity(x => x.EnteredByPerson, 20, x => x.IsRequired());
            Entity(x => x.EnteredByPhoneNumber, 21);
            Entity(x => x.EnteredByLocation, 22);
            Entity(x => x.ParentPlacerAppointmentId, 23);
            Entity(x => x.ParentFillerAppointmentId, 24);
            Entity(x => x.FillerStatusCode, 25);
            Entity(x => x.PlacerOrderNumber, 26);
            Entity(x => x.FillerOrderNumber, 27);
        }
    }
}