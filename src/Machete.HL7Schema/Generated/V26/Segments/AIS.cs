// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// AIS (Segment) - Appointment Information
    /// </summary>
    public interface AIS :
        HL7V26Segment
    {
        /// <summary>
        /// AIS-1: Set ID - AIS
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// AIS-2: Segment Action Code
        /// </summary>
        Value<string> SegmentActionCode { get; }

        /// <summary>
        /// AIS-3: Universal Service Identifier
        /// </summary>
        Value<CWE> UniversalServiceIdentifier { get; }

        /// <summary>
        /// AIS-4: Start Date/Time
        /// </summary>
        Value<DateTimeOffset> StartDateTime { get; }

        /// <summary>
        /// AIS-5: Start Date/Time Offset
        /// </summary>
        Value<decimal> StartDateTimeOffset { get; }

        /// <summary>
        /// AIS-6: Start Date/Time Offset Units
        /// </summary>
        Value<CNE> StartDateTimeOffsetUnits { get; }

        /// <summary>
        /// AIS-7: Duration
        /// </summary>
        Value<decimal> Duration { get; }

        /// <summary>
        /// AIS-8: Duration Units
        /// </summary>
        Value<CNE> DurationUnits { get; }

        /// <summary>
        /// AIS-9: Allow Substitution Code
        /// </summary>
        Value<string> AllowSubstitutionCode { get; }

        /// <summary>
        /// AIS-10: Filler Status Code
        /// </summary>
        Value<CWE> FillerStatusCode { get; }

        /// <summary>
        /// AIS-11: Placer Supplemental Service Information
        /// </summary>
        ValueList<CWE> PlacerSupplementalServiceInformation { get; }

        /// <summary>
        /// AIS-12: Filler Supplemental Service Information
        /// </summary>
        ValueList<CWE> FillerSupplementalServiceInformation { get; }
    }
}