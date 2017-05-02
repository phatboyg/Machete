// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPT (ComponentMap) - Repeat Pattern
    /// </summary>
    public class RPTMap :
        HL7ComponentMap<RPT>
    {
        public RPTMap()
        {
            Entity(x => x.RepeatPatternCode, 0);
            Value(x => x.CalendarAlignment, 1);
            Value(x => x.PhaseRangeBeginValue, 2);
            Value(x => x.PhaseRangeEndValue, 3);
            Value(x => x.PeriodQuantity, 4);
            Value(x => x.PeriodUnits, 5);
            Value(x => x.InstitutionSpecifiedTime, 6);
            Value(x => x.Event, 7);
            Value(x => x.EventOffsetQuantity, 8);
            Value(x => x.EventOffsetUnits, 9);
            Value(x => x.GeneralTimingSpecification, 10);
        }
    }
}