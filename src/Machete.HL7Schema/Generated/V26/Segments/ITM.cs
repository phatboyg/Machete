// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ITM (Segment) - Material Item
    /// </summary>
    public interface ITM :
        HL7V26Segment
    {
        /// <summary>
        /// ITM-1: Item Identifier
        /// </summary>
        Value<EI> ItemIdentifier { get; }

        /// <summary>
        /// ITM-2: Item Description
        /// </summary>
        Value<string> ItemDescription { get; }

        /// <summary>
        /// ITM-3: Item Status
        /// </summary>
        Value<CWE> ItemStatus { get; }

        /// <summary>
        /// ITM-4: Item Type
        /// </summary>
        Value<CWE> ItemType { get; }

        /// <summary>
        /// ITM-5: Item Category
        /// </summary>
        Value<CWE> ItemCategory { get; }

        /// <summary>
        /// ITM-6: Subject to Expiration Indicator
        /// </summary>
        Value<CNE> SubjectToExpirationIndicator { get; }

        /// <summary>
        /// ITM-7: Manufacturer Identifier
        /// </summary>
        Value<EI> ManufacturerIdentifier { get; }

        /// <summary>
        /// ITM-8: Manufacturer Name
        /// </summary>
        Value<string> ManufacturerName { get; }

        /// <summary>
        /// ITM-9: Manufacturer Catalog Number
        /// </summary>
        Value<string> ManufacturerCatalogNumber { get; }

        /// <summary>
        /// ITM-10: Manufacturer Labeler Identification Code
        /// </summary>
        Value<CWE> ManufacturerLabelerIdentificationCode { get; }

        /// <summary>
        /// ITM-11: Patient Chargeable Indicator
        /// </summary>
        Value<CNE> PatientChargeableIndicator { get; }

        /// <summary>
        /// ITM-12: Transaction Code
        /// </summary>
        Value<CWE> TransactionCode { get; }

        /// <summary>
        /// ITM-13: Transaction amount - unit
        /// </summary>
        Value<CP> TransactionAmountUnit { get; }

        /// <summary>
        /// ITM-14: Stocked Item Indicator
        /// </summary>
        Value<CNE> StockedItemIndicator { get; }

        /// <summary>
        /// ITM-15: Supply Risk Codes
        /// </summary>
        Value<CWE> SupplyRiskCodes { get; }

        /// <summary>
        /// ITM-16: Approving Regulatory Agency
        /// </summary>
        ValueList<XON> ApprovingRegulatoryAgency { get; }

        /// <summary>
        /// ITM-17: Latex Indicator
        /// </summary>
        Value<CNE> LatexIndicator { get; }

        /// <summary>
        /// ITM-18: Ruling Act
        /// </summary>
        ValueList<CWE> RulingAct { get; }

        /// <summary>
        /// ITM-19: Item Natural Account Code
        /// </summary>
        Value<string> ItemNaturalAccountCode { get; }

        /// <summary>
        /// ITM-20: Approved To Buy Quantity
        /// </summary>
        Value<decimal> ApprovedToBuyQuantity { get; }

        /// <summary>
        /// ITM-21: Approved To Buy Price
        /// </summary>
        Value<MO> ApprovedToBuyPrice { get; }

        /// <summary>
        /// ITM-22: Taxable Item Indicator
        /// </summary>
        Value<CNE> TaxableItemIndicator { get; }

        /// <summary>
        /// ITM-23: Freight Charge Indicator
        /// </summary>
        Value<CNE> FreightChargeIndicator { get; }

        /// <summary>
        /// ITM-24: Item Set Indicator
        /// </summary>
        Value<CNE> ItemSetIndicator { get; }

        /// <summary>
        /// ITM-25: Item Set Identifier
        /// </summary>
        Value<EI> ItemSetIdentifier { get; }

        /// <summary>
        /// ITM-26: Track Department Usage Indicator
        /// </summary>
        Value<CNE> TrackDepartmentUsageIndicator { get; }

        /// <summary>
        /// ITM-27: Procedure Code
        /// </summary>
        Value<CNE> ProcedureCode { get; }

        /// <summary>
        /// ITM-28: Procedure Code Modifier
        /// </summary>
        ValueList<CNE> ProcedureCodeModifier { get; }

        /// <summary>
        /// ITM-29: Special Handling Code
        /// </summary>
        Value<CWE> SpecialHandlingCode { get; }
    }
}