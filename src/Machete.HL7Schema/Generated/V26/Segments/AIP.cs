// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// AIP (Segment) - Appointment Information - Personnel Resource
    /// </summary>
    public interface AIP :
        HL7V26Segment
    {
        /// <summary>
        /// AIP-1: Set ID - AIP
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// AIP-2: Segment Action Code
        /// </summary>
        Value<string> SegmentActionCode { get; }

        /// <summary>
        /// AIP-3: Personnel Resource ID
        /// </summary>
        ValueList<XCN> PersonnelResourceId { get; }

        /// <summary>
        /// AIP-4: Resource Type
        /// </summary>
        Value<CWE> ResourceType { get; }

        /// <summary>
        /// AIP-5: Resource Group
        /// </summary>
        Value<CWE> ResourceGroup { get; }

        /// <summary>
        /// AIP-6: Start Date/Time
        /// </summary>
        Value<DateTimeOffset> StartDateTime { get; }

        /// <summary>
        /// AIP-7: Start Date/Time Offset
        /// </summary>
        Value<decimal> StartDateTimeOffset { get; }

        /// <summary>
        /// AIP-8: Start Date/Time Offset Units
        /// </summary>
        Value<CNE> StartDateTimeOffsetUnits { get; }

        /// <summary>
        /// AIP-9: Duration
        /// </summary>
        Value<decimal> Duration { get; }

        /// <summary>
        /// AIP-10: Duration Units
        /// </summary>
        Value<CNE> DurationUnits { get; }

        /// <summary>
        /// AIP-11: Allow Substitution Code
        /// </summary>
        Value<string> AllowSubstitutionCode { get; }

        /// <summary>
        /// AIP-12: Filler Status Code
        /// </summary>
        Value<CWE> FillerStatusCode { get; }
    }
}