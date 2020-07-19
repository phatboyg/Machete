// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// NCK (Segment) - System Clock
    /// </summary>
    public interface NCK :
        HL7V26Segment
    {
        /// <summary>
        /// NCK-1: System Date/Time
        /// </summary>
        Value<DateTimeOffset> SystemDateTime { get; }
    }
}