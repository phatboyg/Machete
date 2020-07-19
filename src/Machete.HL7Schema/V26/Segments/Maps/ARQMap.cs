// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ARQ (SegmentMap) - Appointment Request
    /// </summary>
    public class ARQMap :
        HL7V26SegmentMap<ARQ>
    {
        public ARQMap()
        {
            Id = "ARQ";

            Name = "Appointment Request";

            Entity(x => x.PlacerAppointmentId, 1, x => x.IsRequired());
            Entity(x => x.FillerAppointmentId, 2);
            Value(x => x.OccurrenceNumber, 3);
            Entity(x => x.PlacerGroupNumber, 4);
            Entity(x => x.ScheduleId, 5);
            Entity(x => x.RequestEventReason, 6);
            Entity(x => x.AppointmentReason, 7);
            Entity(x => x.AppointmentType, 8);
            Value(x => x.AppointmentDuration, 9);
            Entity(x => x.AppointmentDurationUnits, 10);
            Entity(x => x.RequestedStartDateTimeRange, 11);
            Value(x => x.Priority, 12);
            Entity(x => x.RepeatingInterval, 13);
            Value(x => x.RepeatingIntervalDuration, 14);
            Entity(x => x.PlacerContactPerson, 15, x => x.IsRequired());
            Entity(x => x.PlacerContactPhoneNumber, 16);
            Entity(x => x.PlacerContactAddress, 17);
            Entity(x => x.PlacerContactLocation, 18);
            Entity(x => x.EnteredByPerson, 19, x => x.IsRequired());
            Entity(x => x.EnteredByPhoneNumber, 20);
            Entity(x => x.EnteredByLocation, 21);
            Entity(x => x.ParentPlacerAppointmentId, 22);
            Entity(x => x.ParentFillerAppointmentId, 23);
            Entity(x => x.PlacerOrderNumber, 24);
            Entity(x => x.FillerOrderNumber, 25);
        }
    }
}