// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ARQ (Segment) - Appointment Request
    /// </summary>
    public interface ARQ :
        HL7V26Segment
    {
        /// <summary>
        /// ARQ-1: Placer Appointment ID
        /// </summary>
        Value<EI> PlacerAppointmentId { get; }

        /// <summary>
        /// ARQ-2: Filler Appointment ID
        /// </summary>
        Value<EI> FillerAppointmentId { get; }

        /// <summary>
        /// ARQ-3: Occurrence Number
        /// </summary>
        Value<decimal> OccurrenceNumber { get; }

        /// <summary>
        /// ARQ-4: Placer Group Number
        /// </summary>
        Value<EI> PlacerGroupNumber { get; }

        /// <summary>
        /// ARQ-5: Schedule ID
        /// </summary>
        Value<CWE> ScheduleId { get; }

        /// <summary>
        /// ARQ-6: Request Event Reason
        /// </summary>
        Value<CWE> RequestEventReason { get; }

        /// <summary>
        /// ARQ-7: Appointment Reason
        /// </summary>
        Value<CWE> AppointmentReason { get; }

        /// <summary>
        /// ARQ-8: Appointment Type
        /// </summary>
        Value<CWE> AppointmentType { get; }

        /// <summary>
        /// ARQ-9: Appointment Duration
        /// </summary>
        Value<decimal> AppointmentDuration { get; }

        /// <summary>
        /// ARQ-10: Appointment Duration Units
        /// </summary>
        Value<CNE> AppointmentDurationUnits { get; }

        /// <summary>
        /// ARQ-11: Requested Start Date/Time Range
        /// </summary>
        ValueList<DR> RequestedStartDateTimeRange { get; }

        /// <summary>
        /// ARQ-12: Priority-ARQ
        /// </summary>
        Value<string> Priority { get; }

        /// <summary>
        /// ARQ-13: Repeating Interval
        /// </summary>
        Value<RI> RepeatingInterval { get; }

        /// <summary>
        /// ARQ-14: Repeating Interval Duration
        /// </summary>
        Value<string> RepeatingIntervalDuration { get; }

        /// <summary>
        /// ARQ-15: Placer Contact Person
        /// </summary>
        ValueList<XCN> PlacerContactPerson { get; }

        /// <summary>
        /// ARQ-16: Placer Contact Phone Number
        /// </summary>
        ValueList<XTN> PlacerContactPhoneNumber { get; }

        /// <summary>
        /// ARQ-17: Placer Contact Address
        /// </summary>
        ValueList<XAD> PlacerContactAddress { get; }

        /// <summary>
        /// ARQ-18: Placer Contact Location
        /// </summary>
        Value<PL> PlacerContactLocation { get; }

        /// <summary>
        /// ARQ-19: Entered By Person
        /// </summary>
        ValueList<XCN> EnteredByPerson { get; }

        /// <summary>
        /// ARQ-20: Entered By Phone Number
        /// </summary>
        ValueList<XTN> EnteredByPhoneNumber { get; }

        /// <summary>
        /// ARQ-21: Entered By Location
        /// </summary>
        Value<PL> EnteredByLocation { get; }

        /// <summary>
        /// ARQ-22: Parent Placer Appointment ID
        /// </summary>
        Value<EI> ParentPlacerAppointmentId { get; }

        /// <summary>
        /// ARQ-23: Parent Filler Appointment ID
        /// </summary>
        Value<EI> ParentFillerAppointmentId { get; }

        /// <summary>
        /// ARQ-24: Placer Order Number
        /// </summary>
        ValueList<EI> PlacerOrderNumber { get; }

        /// <summary>
        /// ARQ-25: Filler Order Number
        /// </summary>
        ValueList<EI> FillerOrderNumber { get; }
    }
}