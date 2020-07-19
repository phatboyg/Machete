// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// TQ (ComponentMap) - Timing Quantity
    /// </summary>
    public class TQMap :
        HL7V26ComponentMap<TQ>
    {
        public TQMap()
        {
            Entity(x => x.Quantity, 0);
            Entity(x => x.Interval, 1);
            Value(x => x.Duration, 2);
            Value(x => x.StartDateTime, 3, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.EndDateTime, 4, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.Priority, 5);
            Value(x => x.Condition, 6);
            Value(x => x.Text, 7);
            Value(x => x.Conjunction, 8);
            Entity(x => x.OrderSequencing, 9);
            Entity(x => x.OccurrenceDuration, 10);
            Value(x => x.TotalOccurrences, 11);
        }
    }
}