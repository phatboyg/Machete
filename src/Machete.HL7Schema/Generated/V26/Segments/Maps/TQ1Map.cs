// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// TQ1 (SegmentMap) - Timing/Quantity
    /// </summary>
    public class TQ1Map :
        HL7SegmentMap<TQ1>
    {
        public TQ1Map()
        {
            Id = "TQ1";

            Name = "Timing/Quantity";

            Value(x => x.SetId, 1);
            Entity(x => x.Quantity, 2);
            Entity(x => x.RepeatPattern, 3);
            Value(x => x.ExplicitTime, 4, x => {x.Format = "LONGDATETIME4";});
            Entity(x => x.RelativeTimeAndUnits, 5);
            Entity(x => x.ServiceDuration, 6);
            Value(x => x.StartDateTime, 7, x => {x.Format = "LONGDATETIME7";});
            Value(x => x.EndDateTime, 8, x => {x.Format = "LONGDATETIME8";});
            Entity(x => x.Priority, 9);
            Value(x => x.ConditionText, 10);
            Value(x => x.TextInstruction, 11);
            Value(x => x.Conjunction, 12);
            Entity(x => x.OccurrenceDuration, 13);
            Value(x => x.TotalOccurrences, 14);
        }
    }
}