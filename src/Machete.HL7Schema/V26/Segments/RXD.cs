// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// RXD (Segment) - Pharmacy/Treatment Dispense
    /// </summary>
    public interface RXD :
        HL7V26Segment
    {
        /// <summary>
        /// RXD-1: Dispense Sub-ID Counter
        /// </summary>
        Value<decimal> DispenseSubIdCounter { get; }

        /// <summary>
        /// RXD-2: Dispense/Give Code
        /// </summary>
        Value<CWE> DispenseGiveCode { get; }

        /// <summary>
        /// RXD-3: Date/Time Dispensed
        /// </summary>
        Value<DateTimeOffset> DateTimeDispensed { get; }

        /// <summary>
        /// RXD-4: Actual Dispense Amount
        /// </summary>
        Value<decimal> ActualDispenseAmount { get; }

        /// <summary>
        /// RXD-5: Actual Dispense Units
        /// </summary>
        Value<CWE> ActualDispenseUnits { get; }

        /// <summary>
        /// RXD-6: Actual Dosage Form
        /// </summary>
        Value<CWE> ActualDosageForm { get; }

        /// <summary>
        /// RXD-7: Prescription Number
        /// </summary>
        Value<string> PrescriptionNumber { get; }

        /// <summary>
        /// RXD-8: Number of Refills Remaining
        /// </summary>
        Value<decimal> NumberOfRefillsRemaining { get; }

        /// <summary>
        /// RXD-9: Dispense Notes
        /// </summary>
        ValueList<string> DispenseNotes { get; }

        /// <summary>
        /// RXD-10: Dispensing Provider
        /// </summary>
        ValueList<XCN> DispensingProvider { get; }

        /// <summary>
        /// RXD-11: Substitution Status
        /// </summary>
        Value<string> SubstitutionStatus { get; }

        /// <summary>
        /// RXD-12: Total Daily Dose
        /// </summary>
        Value<CQ> TotalDailyDose { get; }

        /// <summary>
        /// RXD-13: Dispense-to Location
        /// </summary>
        Value<LA2> DispenseToLocation { get; }

        /// <summary>
        /// RXD-14: Needs Human Review
        /// </summary>
        Value<string> NeedHumanReview { get; }

        /// <summary>
        /// RXD-15: Pharmacy/Treatment Supplier's Special Dispensing Instructions
        /// </summary>
        ValueList<CWE> PharmacyTreatmentSupplierSpecialDispensingInstructions { get; }

        /// <summary>
        /// RXD-16: Actual Strength
        /// </summary>
        Value<decimal> ActualStrength { get; }

        /// <summary>
        /// RXD-17: Actual Strength Unit
        /// </summary>
        Value<CWE> ActualStrengthUnit { get; }

        /// <summary>
        /// RXD-18: Substance Lot Number
        /// </summary>
        ValueList<string> SubstanceLotNumber { get; }

        /// <summary>
        /// RXD-19: Substance Expiration Date
        /// </summary>
        ValueList<DateTimeOffset> SubstanceExpirationDate { get; }

        /// <summary>
        /// RXD-20: Substance Manufacturer Name
        /// </summary>
        ValueList<CWE> SubstanceManufacturerName { get; }

        /// <summary>
        /// RXD-21: Indication
        /// </summary>
        ValueList<CWE> Indication { get; }

        /// <summary>
        /// RXD-22: Dispense Package Size
        /// </summary>
        Value<decimal> DispensePackageSize { get; }

        /// <summary>
        /// RXD-23: Dispense Package Size Unit
        /// </summary>
        Value<CWE> DispensePackageSizeUnit { get; }

        /// <summary>
        /// RXD-24: Dispense Package Method
        /// </summary>
        Value<string> DispensePackageMethod { get; }

        /// <summary>
        /// RXD-25: Supplementary Code
        /// </summary>
        ValueList<CWE> SupplementaryCode { get; }

        /// <summary>
        /// RXD-26: Initiating Location
        /// </summary>
        Value<CWE> InitiatingLocation { get; }

        /// <summary>
        /// RXD-27: Packaging/Assembly Location
        /// </summary>
        Value<CWE> PackagingAssemblyLocation { get; }

        /// <summary>
        /// RXD-28: Actual Drug Strength Volume
        /// </summary>
        Value<decimal> ActualDrugStrengthVolume { get; }

        /// <summary>
        /// RXD-29: Actual Drug Strength Volume Units
        /// </summary>
        Value<CWE> ActualDrugStrengthVolumeUnits { get; }

        /// <summary>
        /// RXD-30: Dispense to Pharmacy
        /// </summary>
        Value<CWE> DispenseToPharmacy { get; }

        /// <summary>
        /// RXD-31: Dispense to Pharmacy Address
        /// </summary>
        Value<XAD> DispenseToPharmacyAddress { get; }

        /// <summary>
        /// RXD-32: Pharmacy Order Type
        /// </summary>
        Value<string> PharmacyOrderType { get; }

        /// <summary>
        /// RXD-33: Dispense Type
        /// </summary>
        Value<CWE> DispenseType { get; }
    }
}