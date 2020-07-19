// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RXO (Segment) - Pharmacy/Treatment Order
    /// </summary>
    public interface RXO :
        HL7V26Segment
    {
        /// <summary>
        /// RXO-1: Requested Give Code
        /// </summary>
        Value<CWE> RequestedGiveCode { get; }

        /// <summary>
        /// RXO-2: Requested Give Amount - Minimum
        /// </summary>
        Value<decimal> RequestedGiveAmountMinimum { get; }

        /// <summary>
        /// RXO-3: Requested Give Amount - Maximum
        /// </summary>
        Value<decimal> RequestedGiveAmountMaximum { get; }

        /// <summary>
        /// RXO-4: Requested Give Units
        /// </summary>
        Value<CWE> RequestedGiveUnits { get; }

        /// <summary>
        /// RXO-5: Requested Dosage Form
        /// </summary>
        Value<CWE> RequestedDosageForm { get; }

        /// <summary>
        /// RXO-6: Provider's Pharmacy/Treatment Instructions
        /// </summary>
        ValueList<CWE> ProviderPharmacyTreatmentInstructions { get; }

        /// <summary>
        /// RXO-7: Provider's Administration Instructions
        /// </summary>
        ValueList<CWE> ProviderSAdministrationInstructions { get; }

        /// <summary>
        /// RXO-8: Deliver-To Location
        /// </summary>
        Value<LA1> DeliverToLocation { get; }

        /// <summary>
        /// RXO-9: Allow Substitutions
        /// </summary>
        Value<string> AllowSubstitutions { get; }

        /// <summary>
        /// RXO-10: Requested Dispense Code
        /// </summary>
        Value<CWE> RequestedDispenseCode { get; }

        /// <summary>
        /// RXO-11: Requested Dispense Amount
        /// </summary>
        Value<decimal> RequestedDispenseAmount { get; }

        /// <summary>
        /// RXO-12: Requested Dispense Units
        /// </summary>
        Value<CWE> RequestedDispenseUnits { get; }

        /// <summary>
        /// RXO-13: Number Of Refills
        /// </summary>
        Value<decimal> NumberOfRefills { get; }

        /// <summary>
        /// RXO-14: Ordering Provider's DEA Number
        /// </summary>
        ValueList<XCN> OrderingProviderDEANumber { get; }

        /// <summary>
        /// RXO-15: Pharmacist/Treatment Supplier's Verifier ID
        /// </summary>
        ValueList<XCN> PharmacistTreatmentSupplierVerifierId { get; }

        /// <summary>
        /// RXO-16: Needs Human Review
        /// </summary>
        Value<string> NeedHumanReview { get; }

        /// <summary>
        /// RXO-17: Requested Give Per (Time Unit)
        /// </summary>
        Value<string> RequestedGivePerTimeUnit { get; }

        /// <summary>
        /// RXO-18: Requested Give Strength
        /// </summary>
        Value<decimal> RequestedGiveStrength { get; }

        /// <summary>
        /// RXO-19: Requested Give Strength Units
        /// </summary>
        Value<CWE> RequestedGiveStrengthUnits { get; }

        /// <summary>
        /// RXO-20: Indication
        /// </summary>
        ValueList<CWE> Indication { get; }

        /// <summary>
        /// RXO-21: Requested Give Rate Amount
        /// </summary>
        Value<string> RequestedGiveRateAmount { get; }

        /// <summary>
        /// RXO-22: Requested Give Rate Units
        /// </summary>
        Value<CWE> RequestedGiveRateUnits { get; }

        /// <summary>
        /// RXO-23: Total Daily Dose
        /// </summary>
        Value<CQ> TotalDailyDose { get; }

        /// <summary>
        /// RXO-24: Supplementary Code
        /// </summary>
        ValueList<CWE> SupplementaryCode { get; }

        /// <summary>
        /// RXO-25: Requested Drug Strength Volume
        /// </summary>
        Value<decimal> RequestedDrugStrengthVolume { get; }

        /// <summary>
        /// RXO-26: Requested Drug Strength Volume Units
        /// </summary>
        Value<CWE> RequestedDrugStrengthVolumeUnits { get; }

        /// <summary>
        /// RXO-27: Pharmacy Order Type
        /// </summary>
        Value<string> PharmacyOrderType { get; }

        /// <summary>
        /// RXO-28: Dispensing Interval
        /// </summary>
        Value<decimal> DispensingInterval { get; }

        /// <summary>
        /// RXO-29: Medication Instance Identifier
        /// </summary>
        Value<EI> MedicationInstanceIdentifier { get; }

        /// <summary>
        /// RXO-30: Segment Instance Identifier
        /// </summary>
        Value<EI> SegmentInstanceIdentifier { get; }

        /// <summary>
        /// RXO-31: Mood Code
        /// </summary>
        Value<CNE> MoodCode { get; }

        /// <summary>
        /// RXO-32: Dispensing Pharmacy
        /// </summary>
        Value<CWE> DispensingPharmacy { get; }

        /// <summary>
        /// RXO-33: Dispensing Pharmacy Address
        /// </summary>
        Value<XAD> DispensingPharmacyAddress { get; }

        /// <summary>
        /// RXO-34: Deliver-to Patient Location
        /// </summary>
        Value<PL> DeliverToPatientLocation { get; }

        /// <summary>
        /// RXO-35: Deliver-to Address
        /// </summary>
        Value<XAD> DeliverToAddress { get; }
    }
}