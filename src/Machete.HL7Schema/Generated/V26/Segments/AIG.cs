// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// AIG (Segment) - Appointment Information - General Resource
    /// </summary>
    public interface AIG :
        HL7V26Segment
    {
        /// <summary>
        /// AIG-1: Set ID - AIG
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// AIG-2: Segment Action Code
        /// </summary>
        Value<string> SegmentActionCode { get; }

        /// <summary>
        /// AIG-3: Resource ID
        /// </summary>
        Value<CWE> ResourceId { get; }

        /// <summary>
        /// AIG-4: Resource Type
        /// </summary>
        Value<CWE> ResourceType { get; }

        /// <summary>
        /// AIG-5: Resource Group
        /// </summary>
        ValueList<CWE> ResourceGroup { get; }

        /// <summary>
        /// AIG-6: Resource Quantity
        /// </summary>
        Value<decimal> ResourceQuantity { get; }

        /// <summary>
        /// AIG-7: Resource Quantity Units
        /// </summary>
        Value<CNE> ResourceQuantityUnits { get; }

        /// <summary>
        /// AIG-8: Start Date/Time
        /// </summary>
        Value<DateTimeOffset> StartDateTime { get; }

        /// <summary>
        /// AIG-9: Start Date/Time Offset
        /// </summary>
        Value<decimal> StartDateTimeOffset { get; }

        /// <summary>
        /// AIG-10: Start Date/Time Offset Units
        /// </summary>
        Value<CNE> StartDateTimeOffsetUnits { get; }

        /// <summary>
        /// AIG-11: Duration
        /// </summary>
        Value<decimal> Duration { get; }

        /// <summary>
        /// AIG-12: Duration Units
        /// </summary>
        Value<CNE> DurationUnits { get; }

        /// <summary>
        /// AIG-13: Allow Substitution Code
        /// </summary>
        Value<string> AllowSubstitutionCode { get; }

        /// <summary>
        /// AIG-14: Filler Status Code
        /// </summary>
        Value<CWE> FillerStatusCode { get; }
    }
}