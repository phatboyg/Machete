// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// BLG (Segment) - Billing
    /// </summary>
    public interface BLG :
        HL7V26Segment
    {
        /// <summary>
        /// BLG-1: When to Charge
        /// </summary>
        Value<CCD> WhenToCharge { get; }

        /// <summary>
        /// BLG-2: Charge Type
        /// </summary>
        Value<string> ChargeType { get; }

        /// <summary>
        /// BLG-3: Account ID
        /// </summary>
        Value<CX> AccountId { get; }

        /// <summary>
        /// BLG-4: Charge Type Reason
        /// </summary>
        Value<CWE> ChargeTypeReason { get; }
    }
}