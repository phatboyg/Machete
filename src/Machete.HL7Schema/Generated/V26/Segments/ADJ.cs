// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// ADJ (Segment) - Adjustment
    /// </summary>
    public interface ADJ :
        HL7V26Segment
    {
        /// <summary>
        /// ADJ-1: Provider Adjustment Number
        /// </summary>
        Value<EI> ProviderAdjustmentNumber { get; }

        /// <summary>
        /// ADJ-2: Payer Adjustment Number
        /// </summary>
        Value<EI> PayerAdjustmentNumber { get; }

        /// <summary>
        /// ADJ-3: Adjustment Sequence Number
        /// </summary>
        Value<int> AdjustmentSequenceNumber { get; }

        /// <summary>
        /// ADJ-4: Adjustment Category
        /// </summary>
        Value<string> AdjustmentCategory { get; }

        /// <summary>
        /// ADJ-5: Adjustment Amount
        /// </summary>
        Value<CP> AdjustmentAmount { get; }

        /// <summary>
        /// ADJ-6: Adjustment Quantity
        /// </summary>
        Value<CQ> AdjustmentQuantity { get; }

        /// <summary>
        /// ADJ-7: Adjustment Reason PA
        /// </summary>
        Value<CWE> AdjustmentReasonPA { get; }

        /// <summary>
        /// ADJ-8: Adjustment Description
        /// </summary>
        Value<string> AdjustmentDescription { get; }

        /// <summary>
        /// ADJ-9: Original Value
        /// </summary>
        Value<decimal> OriginalValue { get; }

        /// <summary>
        /// ADJ-10: Substitute Value
        /// </summary>
        Value<decimal> SubstituteValue { get; }

        /// <summary>
        /// ADJ-11: Adjustment Action
        /// </summary>
        Value<string> AdjustmentAction { get; }

        /// <summary>
        /// ADJ-12: Provider Adjustment Number Cross Reference
        /// </summary>
        Value<EI> ProviderAdjustmentNumberCrossReference { get; }

        /// <summary>
        /// ADJ-13: Provider Product/Service Line Item Number Cross Reference
        /// </summary>
        Value<EI> ProviderProductServiceLineItemNumberCrossReference { get; }

        /// <summary>
        /// ADJ-14: Adjustment Date
        /// </summary>
        Value<DateTimeOffset> AdjustmentDate { get; }

        /// <summary>
        /// ADJ-15: Responsible Organization
        /// </summary>
        Value<XON> ResponsibleOrganization { get; }
    }
}