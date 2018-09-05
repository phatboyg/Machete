// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// RXE (Segment) - Pharmacy/Treatment Encoded Order
    /// </summary>
    public interface RXE :
        HL7V26Segment
    {
        /// <summary>
        /// RXE-1: Quantity/Timing
        /// </summary>
        Value<TQ> QuantityTiming { get; }

        /// <summary>
        /// RXE-2: Give Code
        /// </summary>
        Value<CWE> GiveCode { get; }

        /// <summary>
        /// RXE-3: Give Amount - Minimum
        /// </summary>
        Value<decimal> GiveAmountMinimum { get; }

        /// <summary>
        /// RXE-4: Give Amount - Maximum
        /// </summary>
        Value<decimal> GiveAmountMaximum { get; }

        /// <summary>
        /// RXE-5: Give Units
        /// </summary>
        Value<CWE> GiveUnits { get; }

        /// <summary>
        /// RXE-6: Give Dosage Form
        /// </summary>
        Value<CWE> GiveDosageForm { get; }

        /// <summary>
        /// RXE-7: Provider's Administration Instructions
        /// </summary>
        ValueList<CWE> ProviderAdministrationInstructions { get; }

        /// <summary>
        /// RXE-8: Deliver-To Location
        /// </summary>
        Value<LA1> DeliverToLocation { get; }

        /// <summary>
        /// RXE-9: Substitution Status
        /// </summary>
        Value<string> SubstitutionStatus { get; }

        /// <summary>
        /// RXE-10: Dispense Amount
        /// </summary>
        Value<decimal> DispenseAmount { get; }

        /// <summary>
        /// RXE-11: Dispense Units
        /// </summary>
        Value<CWE> DispenseUnits { get; }

        /// <summary>
        /// RXE-12: Number Of Refills
        /// </summary>
        Value<decimal> NumberOfRefills { get; }

        /// <summary>
        /// RXE-13: Ordering Provider's DEA Number
        /// </summary>
        ValueList<XCN> OrderingProviderDEANumber { get; }

        /// <summary>
        /// RXE-14: Pharmacist/Treatment Supplier's Verifier ID
        /// </summary>
        ValueList<XCN> PharmacistTreatmentSupplierVerifierId { get; }

        /// <summary>
        /// RXE-15: Prescription Number
        /// </summary>
        Value<string> PrescriptionNumber { get; }

        /// <summary>
        /// RXE-16: Number of Refills Remaining
        /// </summary>
        Value<decimal> NumberOfRefillsRemaining { get; }

        /// <summary>
        /// RXE-17: Number of Refills/Doses Dispensed
        /// </summary>
        Value<decimal> NumberOfRefillsDosesDispensed { get; }

        /// <summary>
        /// RXE-18: D/T of Most Recent Refill or Dose Dispensed
        /// </summary>
        Value<DateTimeOffset> DTOfMostRecentRefillOrDoseDispensed { get; }

        /// <summary>
        /// RXE-19: Total Daily Dose
        /// </summary>
        Value<CQ> TotalDailyDose { get; }

        /// <summary>
        /// RXE-20: Needs Human Review
        /// </summary>
        Value<string> NeedHumanReview { get; }

        /// <summary>
        /// RXE-21: Pharmacy/Treatment Supplier's Special Dispensing Instructions
        /// </summary>
        ValueList<CWE> PharmacyTreatmentSupplierSpecialDispensingInstructions { get; }

        /// <summary>
        /// RXE-22: Give Per (Time Unit)
        /// </summary>
        Value<string> GivePerTimeUnit { get; }

        /// <summary>
        /// RXE-23: Give Rate Amount
        /// </summary>
        Value<string> GiveRateAmount { get; }

        /// <summary>
        /// RXE-24: Give Rate Units
        /// </summary>
        Value<CWE> GiveRateUnits { get; }

        /// <summary>
        /// RXE-25: Give Strength
        /// </summary>
        Value<decimal> GiveStrength { get; }

        /// <summary>
        /// RXE-26: Give Strength Units
        /// </summary>
        Value<CWE> GiveStrengthUnits { get; }

        /// <summary>
        /// RXE-27: Give Indication
        /// </summary>
        ValueList<CWE> GiveIndication { get; }

        /// <summary>
        /// RXE-28: Dispense Package Size
        /// </summary>
        Value<decimal> DispensePackageSize { get; }

        /// <summary>
        /// RXE-29: Dispense Package Size Unit
        /// </summary>
        Value<CWE> DispensePackageSizeUnit { get; }

        /// <summary>
        /// RXE-30: Dispense Package Method
        /// </summary>
        Value<string> DispensePackageMethod { get; }

        /// <summary>
        /// RXE-31: Supplementary Code
        /// </summary>
        ValueList<CWE> SupplementaryCode { get; }

        /// <summary>
        /// RXE-32: Original Order Date/Time
        /// </summary>
        Value<DateTimeOffset> OriginalOrderDateTime { get; }

        /// <summary>
        /// RXE-33: Give Drug Strength Volume
        /// </summary>
        Value<decimal> GiveDrugStrengthVolume { get; }

        /// <summary>
        /// RXE-34: Give Drug Strength Volume Units
        /// </summary>
        Value<CWE> GiveDrugStrengthVolumeUnits { get; }

        /// <summary>
        /// RXE-35: Controlled Substance Schedule
        /// </summary>
        Value<CWE> ControlledSubstanceSchedule { get; }

        /// <summary>
        /// RXE-36: Formulary Status
        /// </summary>
        Value<string> FormularyStatus { get; }

        /// <summary>
        /// RXE-37: Pharmaceutical Substance Alternative
        /// </summary>
        ValueList<CWE> PharmaceuticalSubstanceAlternative { get; }

        /// <summary>
        /// RXE-38: Pharmacy of Most Recent Fill
        /// </summary>
        Value<CWE> PharmacyOfMostRecentFill { get; }

        /// <summary>
        /// RXE-39: Initial Dispense Amount
        /// </summary>
        Value<decimal> InitialDispenseAmount { get; }

        /// <summary>
        /// RXE-40: Dispensing Pharmacy
        /// </summary>
        Value<CWE> DispensingPharmacy { get; }

        /// <summary>
        /// RXE-41: Dispensing Pharmacy Address
        /// </summary>
        Value<XAD> DispensingPharmacyAddress { get; }

        /// <summary>
        /// RXE-42: Deliver-to Patient Location
        /// </summary>
        Value<PL> DeliverToPatientLocation { get; }

        /// <summary>
        /// RXE-43: Deliver-to Address
        /// </summary>
        Value<XAD> DeliverToAddress { get; }

        /// <summary>
        /// RXE-44: Pharmacy Order Type
        /// </summary>
        Value<string> PharmacyOrderType { get; }
    }
}