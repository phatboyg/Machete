// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// PCE (Segment) - Patient Charge Cost Center Exceptions
    /// </summary>
    public interface PCE :
        HL7V26Segment
    {
        /// <summary>
        /// PCE-1: Set ID - PCE
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// PCE-2: Cost Center Account Number
        /// </summary>
        Value<string> CostCenterAccountNumber { get; }

        /// <summary>
        /// PCE-3: Transaction Code
        /// </summary>
        Value<CWE> TransactionCode { get; }

        /// <summary>
        /// PCE-4: Transaction amount - unit
        /// </summary>
        Value<CP> TransactionAmountUnit { get; }
    }
}