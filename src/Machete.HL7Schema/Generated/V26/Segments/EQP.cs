// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// EQP (Segment) - Equipment/log Service
    /// </summary>
    public interface EQP :
        HL7Segment
    {
        /// <summary>
        /// EQP-1: Event type
        /// </summary>
        Value<CWE> EventType { get; }

        /// <summary>
        /// EQP-2: File Name
        /// </summary>
        Value<string> FileName { get; }

        /// <summary>
        /// EQP-3: Start Date/Time
        /// </summary>
        Value<DateTimeOffset> StartDateTime { get; }

        /// <summary>
        /// EQP-4: End Date/Time
        /// </summary>
        Value<DateTimeOffset> EndDateTime { get; }

        /// <summary>
        /// EQP-5: Transaction Data
        /// </summary>
        Value<FT> TransactionData { get; }
    }
}