// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ITM (SegmentMap) - Material Item
    /// </summary>
    public class ITMMap :
        HL7V26SegmentMap<ITM>
    {
        public ITMMap()
        {
            Id = "ITM";

            Name = "Material Item";

            Entity(x => x.ItemIdentifier, 1, x => x.IsRequired());
            Value(x => x.ItemDescription, 2);
            Entity(x => x.ItemStatus, 3);
            Entity(x => x.ItemType, 4);
            Entity(x => x.ItemCategory, 5);
            Entity(x => x.SubjectToExpirationIndicator, 6);
            Entity(x => x.ManufacturerIdentifier, 7);
            Value(x => x.ManufacturerName, 8);
            Value(x => x.ManufacturerCatalogNumber, 9);
            Entity(x => x.ManufacturerLabelerIdentificationCode, 10);
            Entity(x => x.PatientChargeableIndicator, 11);
            Entity(x => x.TransactionCode, 12);
            Entity(x => x.TransactionAmountUnit, 13);
            Entity(x => x.StockedItemIndicator, 14);
            Entity(x => x.SupplyRiskCodes, 15);
            Entity(x => x.ApprovingRegulatoryAgency, 16);
            Entity(x => x.LatexIndicator, 17);
            Entity(x => x.RulingAct, 18);
            Value(x => x.ItemNaturalAccountCode, 19);
            Value(x => x.ApprovedToBuyQuantity, 20);
            Entity(x => x.ApprovedToBuyPrice, 21);
            Entity(x => x.TaxableItemIndicator, 22);
            Entity(x => x.FreightChargeIndicator, 23);
            Entity(x => x.ItemSetIndicator, 24);
            Entity(x => x.ItemSetIdentifier, 25);
            Entity(x => x.TrackDepartmentUsageIndicator, 26);
            Entity(x => x.ProcedureCode, 27);
            Entity(x => x.ProcedureCodeModifier, 28);
            Entity(x => x.SpecialHandlingCode, 29);
        }
    }
}