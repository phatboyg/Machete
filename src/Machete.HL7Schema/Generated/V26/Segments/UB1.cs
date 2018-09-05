// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// UB1 (Segment) - UB82
    /// </summary>
    public interface UB1 :
        HL7V26Segment
    {
        /// <summary>
        /// UB1-1: Set ID - UB1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// UB1-2: Blood Deductible
        /// </summary>
        Value<DateTimeOffset> BloodDeductible { get; }

        /// <summary>
        /// UB1-3: Blood Furnished-Pints
        /// </summary>
        Value<decimal> BloodFurnishedPints { get; }

        /// <summary>
        /// UB1-4: Blood Replaced-Pints
        /// </summary>
        Value<decimal> BloodReplacedPints { get; }

        /// <summary>
        /// UB1-5: Blood Not Replaced-Pints
        /// </summary>
        Value<decimal> BloodNotReplacedPints { get; }

        /// <summary>
        /// UB1-6: Co-Insurance Days
        /// </summary>
        Value<decimal> CoInsuranceDays { get; }

        /// <summary>
        /// UB1-7: Condition Code
        /// </summary>
        Value<string> ConditionCode { get; }

        /// <summary>
        /// UB1-8: Covered Days
        /// </summary>
        Value<decimal> CoveredDays { get; }

        /// <summary>
        /// UB1-9: Non Covered Days
        /// </summary>
        Value<decimal> NonCoveredDays { get; }

        /// <summary>
        /// UB1-10: Value Amount & Code
        /// </summary>
        Value<UVC> ValueAmountCode { get; }

        /// <summary>
        /// UB1-11: Number Of Grace Days
        /// </summary>
        Value<decimal> NumberOfGraceDays { get; }

        /// <summary>
        /// UB1-12: Special Program Indicator
        /// </summary>
        Value<CWE> SpecialProgramIndicator { get; }

        /// <summary>
        /// UB1-13: Provider Service Review Organization/Utilization Review Approval Indicator
        /// </summary>
        Value<CWE> PSRO_UR_ApprovalIndicator { get; }

        /// <summary>
        /// UB1-14: Provider Service Review Organization/Utilization Review Approved Stay-Fm
        /// </summary>
        Value<DateTimeOffset> PSRO_UR_ApprovedStayFm { get; }

        /// <summary>
        /// UB1-15: Provider Service Review Organization/Utilization Review Approved Stay-To
        /// </summary>
        Value<DateTimeOffset> PSRO_UR_ApprovedStayTo { get; }

        /// <summary>
        /// UB1-16: Occurrence
        /// </summary>
        Value<OCD> Occurrence { get; }

        /// <summary>
        /// UB1-17: Occurrence Span
        /// </summary>
        Value<CWE> OccurrenceSpan { get; }

        /// <summary>
        /// UB1-18: Occur Span Start Date
        /// </summary>
        Value<DateTimeOffset> OccurSpanStartDate { get; }

        /// <summary>
        /// UB1-19: Occur Span End Date
        /// </summary>
        Value<DateTimeOffset> OccurSpanEndDate { get; }

        /// <summary>
        /// UB1-20: UB-82 Locator 2
        /// </summary>
        Value<string> UB82Locator2 { get; }

        /// <summary>
        /// UB1-21: UB-82 Locator 9
        /// </summary>
        Value<string> UB82Locator9 { get; }

        /// <summary>
        /// UB1-22: UB-82 Locator 27
        /// </summary>
        Value<string> UB82Locator27 { get; }

        /// <summary>
        /// UB1-23: UB-82 Locator 45
        /// </summary>
        Value<string> UB82Locator45 { get; }
    }
}