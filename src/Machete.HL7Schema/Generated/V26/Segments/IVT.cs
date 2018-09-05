// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// IVT (Segment) - Material Location
    /// </summary>
    public interface IVT :
        HL7V26Segment
    {
        /// <summary>
        /// IVT-1: Set Id - IVT
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// IVT-2: Inventory Location Identifier
        /// </summary>
        Value<EI> InventoryLocationIdentifier { get; }

        /// <summary>
        /// IVT-3: Inventory Location Name
        /// </summary>
        Value<string> InventoryLocationName { get; }

        /// <summary>
        /// IVT-4: Source Location Identifier
        /// </summary>
        Value<EI> SourceLocationIdentifier { get; }

        /// <summary>
        /// IVT-5: Source Location Name
        /// </summary>
        Value<string> SourceLocationName { get; }

        /// <summary>
        /// IVT-6: Item Status
        /// </summary>
        Value<CWE> ItemStatus { get; }

        /// <summary>
        /// IVT-7: Bin Location Identifier
        /// </summary>
        ValueList<EI> BinLocationIdentifier { get; }

        /// <summary>
        /// IVT-8: Order Packaging
        /// </summary>
        Value<CWE> OrderPackaging { get; }

        /// <summary>
        /// IVT-9: Issue Packaging
        /// </summary>
        Value<CWE> IssuePackaging { get; }

        /// <summary>
        /// IVT-10: Default Inventory Asset Account
        /// </summary>
        Value<EI> DefaultInventoryAssetAccount { get; }

        /// <summary>
        /// IVT-11: Patient Chargeable Indicator
        /// </summary>
        Value<CNE> PatientChargeableIndicator { get; }

        /// <summary>
        /// IVT-12: Transaction Code
        /// </summary>
        Value<CWE> TransactionCode { get; }

        /// <summary>
        /// IVT-13: Transaction amount - unit
        /// </summary>
        Value<CP> TransactionAmountUnit { get; }

        /// <summary>
        /// IVT-14: Item Importance Code
        /// </summary>
        Value<CWE> ItemImportanceCode { get; }

        /// <summary>
        /// IVT-15: Stocked Item Indicator
        /// </summary>
        Value<CNE> StockedItemIndicator { get; }

        /// <summary>
        /// IVT-16: Consignment Item Indicator
        /// </summary>
        Value<CNE> ConsignmentItemIndicator { get; }

        /// <summary>
        /// IVT-17: Reusable Item Indicator
        /// </summary>
        Value<CNE> ReusableItemIndicator { get; }

        /// <summary>
        /// IVT-18: Reusable Cost
        /// </summary>
        Value<CP> ReusableCost { get; }

        /// <summary>
        /// IVT-19: Substitute Item Identifier
        /// </summary>
        ValueList<EI> SubstituteItemIdentifier { get; }

        /// <summary>
        /// IVT-20: Latex-Free Substitute Item Identifier
        /// </summary>
        Value<EI> LatexFreeSubstituteItemIdentifier { get; }

        /// <summary>
        /// IVT-21: Recommended Reorder Theory
        /// </summary>
        Value<CWE> RecommendedReorderTheory { get; }

        /// <summary>
        /// IVT-22: Recommended Safety Stock Days
        /// </summary>
        Value<decimal> RecommendedSafetyStockDays { get; }

        /// <summary>
        /// IVT-23: Recommended Maximum Days Inventory
        /// </summary>
        Value<decimal> RecommendedMaximumDaysInventory { get; }

        /// <summary>
        /// IVT-24: Recommended Order Point
        /// </summary>
        Value<decimal> RecommendedOrderPoint { get; }

        /// <summary>
        /// IVT-25: Recommended Order Amount
        /// </summary>
        Value<decimal> RecommendedOrderAmount { get; }

        /// <summary>
        /// IVT-26: Operating Room Par Level Indicator
        /// </summary>
        Value<CNE> OperatingRoomParLevelIndicator { get; }
    }
}