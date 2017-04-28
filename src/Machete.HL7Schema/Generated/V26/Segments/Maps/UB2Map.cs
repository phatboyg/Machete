// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// UB2 (SegmentMap) - UB92 Data
    /// </summary>
    public class UB2Map :
        HL7SegmentMap<UB2>
    {
        public UB2Map()
        {
            Id = "UB2";

            Name = "UB92 Data";

            Value(x => x.SetId, 1);
            Value(x => x.CoInsuranceDays9, 2);
            Value(x => x.ConditionCode2430, 3);
            Value(x => x.CoveredDays7, 4);
            Value(x => x.NonCoveredDays8, 5);
            Entity(x => x.ValueAmountCode, 6);
            Entity(x => x.OccurrenceCodeDate3235, 7);
            Entity(x => x.OccurrenceSpanCodeDates, 8);
            Value(x => x.UB92Locator2State, 9);
            Value(x => x.UB92Locator11State, 10);
            Value(x => x.UB92Locator31National, 11);
            Value(x => x.DocumentControlNumber, 12);
            Value(x => x.UB92Locator49National, 13);
            Value(x => x.UB92Locator56State, 14);
            Value(x => x.UB92Locator57National, 15);
            Value(x => x.UB92Locator78State, 16);
            Value(x => x.SpecialVisitCount, 17);
        }
    }
}