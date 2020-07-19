// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// GP1 (Segment) - Grouping/Reimbursement - Visit
    /// </summary>
    public interface GP1 :
        HL7V26Segment
    {
        /// <summary>
        /// GP1-1: Type of Bill Code
        /// </summary>
        Value<string> TypeOfBillCode { get; }

        /// <summary>
        /// GP1-2: Revenue Code
        /// </summary>
        ValueList<string> RevenueCode { get; }

        /// <summary>
        /// GP1-3: Overall Claim Disposition Code
        /// </summary>
        Value<string> OverallClaimDispositionCode { get; }

        /// <summary>
        /// GP1-4: OCE Edits per Visit Code
        /// </summary>
        ValueList<string> OCEEditPerVisitCode { get; }

        /// <summary>
        /// GP1-5: Outlier Cost
        /// </summary>
        Value<CP> OutlierCost { get; }
    }
}