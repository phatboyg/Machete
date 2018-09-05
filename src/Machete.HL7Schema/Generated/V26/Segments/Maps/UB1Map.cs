// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// UB1 (SegmentMap) - UB82
    /// </summary>
    public class UB1Map :
        HL7V26SegmentMap<UB1>
    {
        public UB1Map()
        {
            Id = "UB1";

            Name = "UB82";

            Value(x => x.SetId, 1);
            Value(x => x.BloodDeductible, 2, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.BloodFurnishedPints, 3);
            Value(x => x.BloodReplacedPints, 4);
            Value(x => x.BloodNotReplacedPints, 5);
            Value(x => x.CoInsuranceDays, 6);
            Value(x => x.ConditionCode, 7);
            Value(x => x.CoveredDays, 8);
            Value(x => x.NonCoveredDays, 9);
            Entity(x => x.ValueAmountCode, 10);
            Value(x => x.NumberOfGraceDays, 11);
            Entity(x => x.SpecialProgramIndicator, 12);
            Entity(x => x.PSRO_UR_ApprovalIndicator, 13);
            Value(x => x.PSRO_UR_ApprovedStayFm, 14, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.PSRO_UR_ApprovedStayTo, 15, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.Occurrence, 16);
            Entity(x => x.OccurrenceSpan, 17);
            Value(x => x.OccurSpanStartDate, 18, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.OccurSpanEndDate, 19, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.UB82Locator2, 20);
            Value(x => x.UB82Locator9, 21);
            Value(x => x.UB82Locator27, 22);
            Value(x => x.UB82Locator45, 23);
        }
    }
}