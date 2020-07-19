// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// RXG (Segment) - Pharmacy/Treatment Give
    /// </summary>
    public interface RXG :
        HL7V26Segment
    {
        /// <summary>
        /// RXG-1: Give Sub-ID Counter
        /// </summary>
        Value<decimal> GiveSubIdCounter { get; }

        /// <summary>
        /// RXG-2: Dispense Sub-ID Counter
        /// </summary>
        Value<decimal> DispenseSubIdCounter { get; }

        /// <summary>
        /// RXG-3: Quantity/Timing
        /// </summary>
        Value<TQ> QuantityTiming { get; }

        /// <summary>
        /// RXG-4: Give Code
        /// </summary>
        Value<CWE> GiveCode { get; }

        /// <summary>
        /// RXG-5: Give Amount - Minimum
        /// </summary>
        Value<decimal> GiveAmountMinimum { get; }

        /// <summary>
        /// RXG-6: Give Amount - Maximum
        /// </summary>
        Value<decimal> GiveAmountMaximum { get; }

        /// <summary>
        /// RXG-7: Give Units
        /// </summary>
        Value<CWE> GiveUnits { get; }

        /// <summary>
        /// RXG-8: Give Dosage Form
        /// </summary>
        Value<CWE> GiveDosageForm { get; }

        /// <summary>
        /// RXG-9: Administration Notes
        /// </summary>
        ValueList<CWE> AdministrationNotes { get; }

        /// <summary>
        /// RXG-10: Substitution Status
        /// </summary>
        Value<string> SubstitutionStatus { get; }

        /// <summary>
        /// RXG-11: Dispense-to Location
        /// </summary>
        Value<LA2> DispenseToLocation { get; }

        /// <summary>
        /// RXG-12: Needs Human Review
        /// </summary>
        Value<string> NeedHumanReview { get; }

        /// <summary>
        /// RXG-13: Pharmacy/Treatment Supplier's Special Administration Instructions
        /// </summary>
        ValueList<CWE> PharmacyTreatmentSupplierSpecialAdministrationInstructions { get; }

        /// <summary>
        /// RXG-14: Give Per (Time Unit)
        /// </summary>
        Value<string> GivePerTimeUnit { get; }

        /// <summary>
        /// RXG-15: Give Rate Amount
        /// </summary>
        Value<string> GiveRateAmount { get; }

        /// <summary>
        /// RXG-16: Give Rate Units
        /// </summary>
        Value<CWE> GiveRateUnits { get; }

        /// <summary>
        /// RXG-17: Give Strength
        /// </summary>
        Value<decimal> GiveStrength { get; }

        /// <summary>
        /// RXG-18: Give Strength Units
        /// </summary>
        Value<CWE> GiveStrengthUnits { get; }

        /// <summary>
        /// RXG-19: Substance Lot Number
        /// </summary>
        ValueList<string> SubstanceLotNumber { get; }

        /// <summary>
        /// RXG-20: Substance Expiration Date
        /// </summary>
        ValueList<DateTimeOffset> SubstanceExpirationDate { get; }

        /// <summary>
        /// RXG-21: Substance Manufacturer Name
        /// </summary>
        ValueList<CWE> SubstanceManufacturerName { get; }

        /// <summary>
        /// RXG-22: Indication
        /// </summary>
        ValueList<CWE> Indication { get; }

        /// <summary>
        /// RXG-23: Give Drug Strength Volume
        /// </summary>
        Value<decimal> GiveDrugStrengthVolume { get; }

        /// <summary>
        /// RXG-24: Give Drug Strength Volume Units
        /// </summary>
        Value<CWE> GiveDrugStrengthVolumeUnits { get; }

        /// <summary>
        /// RXG-25: Give Barcode Identifier
        /// </summary>
        Value<CWE> GiveBarcodeIdentifier { get; }

        /// <summary>
        /// RXG-26: Pharmacy Order Type
        /// </summary>
        Value<string> PharmacyOrderType { get; }

        /// <summary>
        /// RXG-27: Dispense to Pharmacy
        /// </summary>
        Value<CWE> DispenseToPharmacy { get; }

        /// <summary>
        /// RXG-28: Dispense to Pharmacy Address
        /// </summary>
        Value<XAD> DispenseToPharmacyAddress { get; }

        /// <summary>
        /// RXG-29: Deliver-to Patient Location
        /// </summary>
        Value<PL> DeliverToPatientLocation { get; }

        /// <summary>
        /// RXG-30: Deliver-to Address
        /// </summary>
        Value<XAD> DeliverToAddress { get; }
    }
}