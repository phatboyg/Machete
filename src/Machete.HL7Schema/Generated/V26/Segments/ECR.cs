// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// ECR (Segment) - Equipment Command Response
    /// </summary>
    public interface ECR :
        HL7V26Segment
    {
        /// <summary>
        /// ECR-1: Command Response
        /// </summary>
        Value<CWE> CommandResponse { get; }

        /// <summary>
        /// ECR-2: Date/Time Completed
        /// </summary>
        Value<DateTimeOffset> DateTimeCompleted { get; }

        /// <summary>
        /// ECR-3: Command Response Parameters
        /// </summary>
        ValueList<TX> CommandResponseParameters { get; }
    }
}