// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// IVT (SegmentMap) - Material Location
    /// </summary>
    public class IVTMap :
        HL7V26SegmentMap<IVT>
    {
        public IVTMap()
        {
            Id = "IVT";

            Name = "Material Location";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Entity(x => x.InventoryLocationIdentifier, 2, x => {x.Required = true;});
            Value(x => x.InventoryLocationName, 3);
            Entity(x => x.SourceLocationIdentifier, 4);
            Value(x => x.SourceLocationName, 5);
            Entity(x => x.ItemStatus, 6);
            Entity(x => x.BinLocationIdentifier, 7);
            Entity(x => x.OrderPackaging, 8);
            Entity(x => x.IssuePackaging, 9);
            Entity(x => x.DefaultInventoryAssetAccount, 10);
            Entity(x => x.PatientChargeableIndicator, 11);
            Entity(x => x.TransactionCode, 12);
            Entity(x => x.TransactionAmountUnit, 13);
            Entity(x => x.ItemImportanceCode, 14);
            Entity(x => x.StockedItemIndicator, 15);
            Entity(x => x.ConsignmentItemIndicator, 16);
            Entity(x => x.ReusableItemIndicator, 17);
            Entity(x => x.ReusableCost, 18);
            Entity(x => x.SubstituteItemIdentifier, 19);
            Entity(x => x.LatexFreeSubstituteItemIdentifier, 20);
            Entity(x => x.RecommendedReorderTheory, 21);
            Value(x => x.RecommendedSafetyStockDays, 22);
            Value(x => x.RecommendedMaximumDaysInventory, 23);
            Value(x => x.RecommendedOrderPoint, 24);
            Value(x => x.RecommendedOrderAmount, 25);
            Entity(x => x.OperatingRoomParLevelIndicator, 26);
        }
    }
}