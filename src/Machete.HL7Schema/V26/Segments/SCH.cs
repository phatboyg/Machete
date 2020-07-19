// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// SCH (Segment) - Scheduling Activity Information
    /// </summary>
    public interface SCH :
        HL7V26Segment
    {
        /// <summary>
        /// SCH-1: Placer Appointment ID
        /// </summary>
        Value<EI> PlacerAppointmentId { get; }

        /// <summary>
        /// SCH-2: Filler Appointment ID
        /// </summary>
        Value<EI> FillerAppointmentId { get; }

        /// <summary>
        /// SCH-3: Occurrence Number
        /// </summary>
        Value<decimal> OccurrenceNumber { get; }

        /// <summary>
        /// SCH-4: Placer Group Number
        /// </summary>
        Value<EI> PlacerGroupNumber { get; }

        /// <summary>
        /// SCH-5: Schedule ID
        /// </summary>
        Value<CWE> ScheduleId { get; }

        /// <summary>
        /// SCH-6: Event Reason
        /// </summary>
        Value<CWE> EventReason { get; }

        /// <summary>
        /// SCH-7: Appointment Reason
        /// </summary>
        Value<CWE> AppointmentReason { get; }

        /// <summary>
        /// SCH-8: Appointment Type
        /// </summary>
        Value<CWE> AppointmentType { get; }

        /// <summary>
        /// SCH-9: Appointment Duration
        /// </summary>
        Value<decimal> AppointmentDuration { get; }

        /// <summary>
        /// SCH-10: Appointment Duration Units
        /// </summary>
        Value<CNE> AppointmentDurationUnits { get; }

        /// <summary>
        /// SCH-11: Appointment Timing Quantity
        /// </summary>
        ValueList<TQ> AppointmentTimingQuantity { get; }

        /// <summary>
        /// SCH-12: Placer Contact Person
        /// </summary>
        ValueList<XCN> PlacerContactPerson { get; }

        /// <summary>
        /// SCH-13: Placer Contact Phone Number
        /// </summary>
        Value<XTN> PlacerContactPhoneNumber { get; }

        /// <summary>
        /// SCH-14: Placer Contact Address
        /// </summary>
        ValueList<XAD> PlacerContactAddress { get; }

        /// <summary>
        /// SCH-15: Placer Contact Location
        /// </summary>
        Value<PL> PlacerContactLocation { get; }

        /// <summary>
        /// SCH-16: Filler Contact Person
        /// </summary>
        ValueList<XCN> FillerContactPerson { get; }

        /// <summary>
        /// SCH-17: Filler Contact Phone Number
        /// </summary>
        Value<XTN> FillerContactPhoneNumber { get; }

        /// <summary>
        /// SCH-18: Filler Contact Address
        /// </summary>
        ValueList<XAD> FillerContactAddress { get; }

        /// <summary>
        /// SCH-19: Filler Contact Location
        /// </summary>
        Value<PL> FillerContactLocation { get; }

        /// <summary>
        /// SCH-20: Entered By Person
        /// </summary>
        ValueList<XCN> EnteredByPerson { get; }

        /// <summary>
        /// SCH-21: Entered By Phone Number
        /// </summary>
        ValueList<XTN> EnteredByPhoneNumber { get; }

        /// <summary>
        /// SCH-22: Entered By Location
        /// </summary>
        Value<PL> EnteredByLocation { get; }

        /// <summary>
        /// SCH-23: Parent Placer Appointment ID
        /// </summary>
        Value<EI> ParentPlacerAppointmentId { get; }

        /// <summary>
        /// SCH-24: Parent Filler Appointment ID
        /// </summary>
        Value<EI> ParentFillerAppointmentId { get; }

        /// <summary>
        /// SCH-25: Filler Status Code
        /// </summary>
        Value<CWE> FillerStatusCode { get; }

        /// <summary>
        /// SCH-26: Placer Order Number
        /// </summary>
        ValueList<EI> PlacerOrderNumber { get; }

        /// <summary>
        /// SCH-27: Filler Order Number
        /// </summary>
        ValueList<EI> FillerOrderNumber { get; }
    }
}