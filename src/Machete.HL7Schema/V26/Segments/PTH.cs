// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PTH (Segment) - Pathway
    /// </summary>
    public interface PTH :
        HL7V26Segment
    {
        /// <summary>
        /// PTH-1: Action Code
        /// </summary>
        Value<string> ActionCode { get; }

        /// <summary>
        /// PTH-2: Pathway ID
        /// </summary>
        Value<CWE> PathwayId { get; }

        /// <summary>
        /// PTH-3: Pathway Instance ID
        /// </summary>
        Value<EI> PathwayInstanceId { get; }

        /// <summary>
        /// PTH-4: Pathway Established Date/Time
        /// </summary>
        Value<DateTimeOffset> PathwayEstablishedDateTime { get; }

        /// <summary>
        /// PTH-5: Pathway Life Cycle Status
        /// </summary>
        Value<CWE> PathwayLifeCycleStatus { get; }

        /// <summary>
        /// PTH-6: Change Pathway Life Cycle Status Date/Time
        /// </summary>
        Value<DateTimeOffset> ChangePathwayLifeCycleStatusDateTime { get; }

        /// <summary>
        /// PTH-7: Mood Code
        /// </summary>
        Value<CNE> MoodCode { get; }
    }
}