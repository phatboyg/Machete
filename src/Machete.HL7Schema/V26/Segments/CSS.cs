// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// CSS (Segment) - Clinical Study Data Schedule Segment
    /// </summary>
    public interface CSS :
        HL7V26Segment
    {
        /// <summary>
        /// CSS-1: Study Scheduled Time Point
        /// </summary>
        Value<CWE> StudyScheduledTimePoint { get; }

        /// <summary>
        /// CSS-2: Study Scheduled Patient Time Point
        /// </summary>
        Value<DateTimeOffset> StudyScheduledPatientTimePoint { get; }

        /// <summary>
        /// CSS-3: Study Quality Control Codes
        /// </summary>
        Value<CWE> StudyQualityControlCodes { get; }
    }
}