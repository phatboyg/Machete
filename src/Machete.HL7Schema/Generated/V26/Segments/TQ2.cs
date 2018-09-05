// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// TQ2 (Segment) - Timing/Quantity Relationship
    /// </summary>
    public interface TQ2 :
        HL7V26Segment
    {
        /// <summary>
        /// TQ2-1: Set ID - TQ2
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// TQ2-2: Sequence/Results Flag
        /// </summary>
        Value<string> SequenceResultsFlag { get; }

        /// <summary>
        /// TQ2-3: Related Placer Number
        /// </summary>
        ValueList<EI> RelatedPlacerNumber { get; }

        /// <summary>
        /// TQ2-4: Related Filler Number
        /// </summary>
        ValueList<EI> RelatedFillerNumber { get; }

        /// <summary>
        /// TQ2-5: Related Placer Group Number
        /// </summary>
        ValueList<EI> RelatedPlacerGroupNumber { get; }

        /// <summary>
        /// TQ2-6: Sequence Condition Code
        /// </summary>
        Value<string> SequenceConditionCode { get; }

        /// <summary>
        /// TQ2-7: Cyclic Entry/Exit Indicator
        /// </summary>
        Value<string> CyclicEntryExitIndicator { get; }

        /// <summary>
        /// TQ2-8: Sequence Condition Time Interval
        /// </summary>
        Value<CQ> SequenceConditionTimeInterval { get; }

        /// <summary>
        /// TQ2-9: Cyclic Group Maximum Number of Repeats
        /// </summary>
        Value<decimal> CyclicGroupMaximumNumberOfRepeats { get; }

        /// <summary>
        /// TQ2-10: Special Service Request Relationship
        /// </summary>
        Value<string> SpecialServiceRequestRelationship { get; }
    }
}