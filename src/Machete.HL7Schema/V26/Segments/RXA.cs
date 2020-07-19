// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// RXA (Segment) - Pharmacy/Treatment Administration
    /// </summary>
    public interface RXA :
        HL7V26Segment
    {
        /// <summary>
        /// RXA-1: Give Sub-ID Counter
        /// </summary>
        Value<decimal> GiveSubIdCounter { get; }

        /// <summary>
        /// RXA-2: Administration Sub-ID Counter
        /// </summary>
        Value<decimal> AdministrationSubIdCounter { get; }

        /// <summary>
        /// RXA-3: Date/Time Start of Administration
        /// </summary>
        Value<DateTimeOffset> DateTimeStartOfAdministration { get; }

        /// <summary>
        /// RXA-4: Date/Time End of Administration
        /// </summary>
        Value<DateTimeOffset> DateTimeEndOfAdministration { get; }

        /// <summary>
        /// RXA-5: Administered Code
        /// </summary>
        Value<CWE> AdministeredCode { get; }

        /// <summary>
        /// RXA-6: Administered Amount
        /// </summary>
        Value<decimal> AdministeredAmount { get; }

        /// <summary>
        /// RXA-7: Administered Units
        /// </summary>
        Value<CWE> AdministeredUnits { get; }

        /// <summary>
        /// RXA-8: Administered Dosage Form
        /// </summary>
        Value<CWE> AdministeredDosageForm { get; }

        /// <summary>
        /// RXA-9: Administration Notes
        /// </summary>
        ValueList<CWE> AdministrationNotes { get; }

        /// <summary>
        /// RXA-10: Administering Provider
        /// </summary>
        ValueList<XCN> AdministeringProvider { get; }

        /// <summary>
        /// RXA-11: Administered-at Location
        /// </summary>
        Value<LA2> AdministeredAtLocation { get; }

        /// <summary>
        /// RXA-12: Administered Per (Time Unit)
        /// </summary>
        Value<string> AdministeredPerTimeUnit { get; }

        /// <summary>
        /// RXA-13: Administered Strength
        /// </summary>
        Value<decimal> AdministeredStrength { get; }

        /// <summary>
        /// RXA-14: Administered Strength Units
        /// </summary>
        Value<CWE> AdministeredStrengthUnits { get; }

        /// <summary>
        /// RXA-15: Substance Lot Number
        /// </summary>
        ValueList<string> SubstanceLotNumber { get; }

        /// <summary>
        /// RXA-16: Substance Expiration Date
        /// </summary>
        ValueList<DateTimeOffset> SubstanceExpirationDate { get; }

        /// <summary>
        /// RXA-17: Substance Manufacturer Name
        /// </summary>
        ValueList<CWE> SubstanceManufacturerName { get; }

        /// <summary>
        /// RXA-18: Substance/Treatment Refusal Reason
        /// </summary>
        ValueList<CWE> SubstanceTreatmentRefusalReason { get; }

        /// <summary>
        /// RXA-19: Indication
        /// </summary>
        ValueList<CWE> Indication { get; }

        /// <summary>
        /// RXA-20: Completion Status
        /// </summary>
        Value<string> CompletionStatus { get; }

        /// <summary>
        /// RXA-21: Action Code - RXA
        /// </summary>
        Value<string> ActionCode { get; }

        /// <summary>
        /// RXA-22: System Entry Date/Time
        /// </summary>
        Value<DateTimeOffset> SystemEntryDateTime { get; }

        /// <summary>
        /// RXA-23: Administered Drug Strength Volume
        /// </summary>
        Value<decimal> AdministeredDrugStrengthVolume { get; }

        /// <summary>
        /// RXA-24: Administered Drug Strength Volume Units
        /// </summary>
        Value<CWE> AdministeredDrugStrengthVolumeUnits { get; }

        /// <summary>
        /// RXA-25: Administered Barcode Identifier
        /// </summary>
        Value<CWE> AdministeredBarcodeIdentifier { get; }

        /// <summary>
        /// RXA-26: Pharmacy Order Type
        /// </summary>
        Value<string> PharmacyOrderType { get; }

        /// <summary>
        /// RXA-27: Administer-at
        /// </summary>
        Value<PL> AdministerAt { get; }

        /// <summary>
        /// RXA-28: Administered-at Address
        /// </summary>
        Value<XAD> AdministeredAtAddress { get; }
    }
}