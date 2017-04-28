// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// TQ2 (SegmentMap) - Timing/Quantity Relationship
    /// </summary>
    public class TQ2Map :
        HL7SegmentMap<TQ2>
    {
        public TQ2Map()
        {
            Id = "TQ2";

            Name = "Timing/Quantity Relationship";

            Value(x => x.SetId, 1);
            Value(x => x.SequenceResultsFlag, 2);
            Entity(x => x.RelatedPlacerNumber, 3);
            Entity(x => x.RelatedFillerNumber, 4);
            Entity(x => x.RelatedPlacerGroupNumber, 5);
            Value(x => x.SequenceConditionCode, 6);
            Value(x => x.CyclicEntryExitIndicator, 7);
            Entity(x => x.SequenceConditionTimeInterval, 8);
            Value(x => x.CyclicGroupMaximumNumberOfRepeats, 9);
            Value(x => x.SpecialServiceRequestRelationship, 10);
        }
    }
}