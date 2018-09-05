// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// AIL (Segment) - Appointment Information - Location Resource
    /// </summary>
    public interface AIL :
        HL7V26Segment
    {
        /// <summary>
        /// AIL-1: Set ID - AIL
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// AIL-2: Segment Action Code
        /// </summary>
        Value<string> SegmentActionCode { get; }

        /// <summary>
        /// AIL-3: Location Resource ID
        /// </summary>
        ValueList<PL> LocationResourceId { get; }

        /// <summary>
        /// AIL-4: Location Type - AIL
        /// </summary>
        Value<CWE> LocationType { get; }

        /// <summary>
        /// AIL-5: Location Group
        /// </summary>
        Value<CWE> LocationGroup { get; }

        /// <summary>
        /// AIL-6: Start Date/Time
        /// </summary>
        Value<DateTimeOffset> StartDateTime { get; }

        /// <summary>
        /// AIL-7: Start Date/Time Offset
        /// </summary>
        Value<decimal> StartDateTimeOffset { get; }

        /// <summary>
        /// AIL-8: Start Date/Time Offset Units
        /// </summary>
        Value<CNE> StartDateTimeOffsetUnits { get; }

        /// <summary>
        /// AIL-9: Duration
        /// </summary>
        Value<decimal> Duration { get; }

        /// <summary>
        /// AIL-10: Duration Units
        /// </summary>
        Value<CNE> DurationUnits { get; }

        /// <summary>
        /// AIL-11: Allow Substitution Code
        /// </summary>
        Value<string> AllowSubstitutionCode { get; }

        /// <summary>
        /// AIL-12: Filler Status Code
        /// </summary>
        Value<CWE> FillerStatusCode { get; }
    }
}