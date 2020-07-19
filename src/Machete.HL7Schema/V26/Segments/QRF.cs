// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// QRF (Segment) - Original style query filter
    /// </summary>
    public interface QRF :
        HL7V26Segment
    {
        /// <summary>
        /// QRF-1: Where Subject Filter
        /// </summary>
        ValueList<string> WhereSubjectFilter { get; }

        /// <summary>
        /// QRF-2: When Data Start Date/Time
        /// </summary>
        Value<DateTimeOffset> WhenDataStartDateTime { get; }

        /// <summary>
        /// QRF-3: When Data End Date/Time
        /// </summary>
        Value<DateTimeOffset> WhenDataEndDateTime { get; }

        /// <summary>
        /// QRF-4: What User Qualifier
        /// </summary>
        ValueList<string> WhatUserQualifier { get; }

        /// <summary>
        /// QRF-5: Other QRY Subject Filter
        /// </summary>
        ValueList<string> OtherQRYSubjectFilter { get; }

        /// <summary>
        /// QRF-6: Which Date/Time Qualifier
        /// </summary>
        ValueList<string> WhichDateTimeQualifier { get; }

        /// <summary>
        /// QRF-7: Which Date/Time Status Qualifier
        /// </summary>
        ValueList<string> WhichDateTimeStatusQualifier { get; }

        /// <summary>
        /// QRF-8: Date/Time Selection Qualifier
        /// </summary>
        ValueList<string> DateTimeSelectionQualifier { get; }

        /// <summary>
        /// QRF-9: When Quantity/Timing Qualifier
        /// </summary>
        Value<TQ> WhenQuantityTimingQualifier { get; }

        /// <summary>
        /// QRF-10: Search Confidence Threshold
        /// </summary>
        Value<decimal> SearchConfidenceThreshold { get; }
    }
}