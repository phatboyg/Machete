// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// GP2 (Segment) - Grouping/Reimbursement - Procedure Line Item
    /// </summary>
    public interface GP2 :
        HL7V26Segment
    {
        /// <summary>
        /// GP2-1: Revenue Code
        /// </summary>
        Value<string> RevenueCode { get; }

        /// <summary>
        /// GP2-2: Number of Service Units
        /// </summary>
        Value<decimal> NumberOfServiceUnits { get; }

        /// <summary>
        /// GP2-3: Charge
        /// </summary>
        Value<CP> Charge { get; }

        /// <summary>
        /// GP2-4: Reimbursement Action Code
        /// </summary>
        Value<string> ReimbursementActionCode { get; }

        /// <summary>
        /// GP2-5: Denial or Rejection Code
        /// </summary>
        Value<string> DenialOrRejectionCode { get; }

        /// <summary>
        /// GP2-6: OCE Edit Code
        /// </summary>
        ValueList<string> OCEEditCode { get; }

        /// <summary>
        /// GP2-7: Ambulatory Payment Classification Code
        /// </summary>
        Value<CWE> AmbulatoryPaymentClassificationCode { get; }

        /// <summary>
        /// GP2-8: Modifier Edit Code
        /// </summary>
        ValueList<string> ModifierEditCode { get; }

        /// <summary>
        /// GP2-9: Payment Adjustment Code
        /// </summary>
        Value<string> PaymentAdjustmentCode { get; }

        /// <summary>
        /// GP2-10: Packaging Status Code
        /// </summary>
        Value<string> PackagingStatusCode { get; }

        /// <summary>
        /// GP2-11: Expected CMS Payment Amount
        /// </summary>
        Value<CP> ExpectedCMSPaymentAmount { get; }

        /// <summary>
        /// GP2-12: Reimbursement Type Code
        /// </summary>
        Value<string> ReimbursementTypeCode { get; }

        /// <summary>
        /// GP2-13: Co-Pay Amount
        /// </summary>
        Value<CP> CoPayAmount { get; }

        /// <summary>
        /// GP2-14: Pay Rate per Service Unit
        /// </summary>
        Value<decimal> PayRatePerServiceUnit { get; }
    }
}