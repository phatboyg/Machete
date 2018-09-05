// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// EQU (Segment) - Equipment Detail
    /// </summary>
    public interface EQU :
        HL7V26Segment
    {
        /// <summary>
        /// EQU-1: Equipment Instance Identifier
        /// </summary>
        Value<EI> EquipmentInstanceIdentifier { get; }

        /// <summary>
        /// EQU-2: Event Date/Time
        /// </summary>
        Value<DateTimeOffset> EventDateTime { get; }

        /// <summary>
        /// EQU-3: Equipment State
        /// </summary>
        Value<CWE> EquipmentState { get; }

        /// <summary>
        /// EQU-4: Local/Remote Control State
        /// </summary>
        Value<CWE> LocalRemoteControlState { get; }

        /// <summary>
        /// EQU-5: Alert Level
        /// </summary>
        Value<CWE> AlertLevel { get; }
    }
}