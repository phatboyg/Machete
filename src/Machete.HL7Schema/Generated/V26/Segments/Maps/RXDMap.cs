// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RXD (SegmentMap) - Pharmacy/Treatment Dispense
    /// </summary>
    public class RXDMap :
        HL7V26SegmentMap<RXD>
    {
        public RXDMap()
        {
            Id = "RXD";

            Name = "Pharmacy/Treatment Dispense";

            Value(x => x.DispenseSubIdCounter, 1, x => {x.Required = true;});
            Entity(x => x.DispenseGiveCode, 2, x => {x.Required = true;});
            Value(x => x.DateTimeDispensed, 3, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;x.Required = true;});
            Value(x => x.ActualDispenseAmount, 4, x => {x.Required = true;});
            Entity(x => x.ActualDispenseUnits, 5);
            Entity(x => x.ActualDosageForm, 6);
            Value(x => x.PrescriptionNumber, 7, x => {x.Required = true;});
            Value(x => x.NumberOfRefillsRemaining, 8);
            Value(x => x.DispenseNotes, 9);
            Entity(x => x.DispensingProvider, 10);
            Value(x => x.SubstitutionStatus, 11);
            Entity(x => x.TotalDailyDose, 12);
            Entity(x => x.DispenseToLocation, 13);
            Value(x => x.NeedHumanReview, 14);
            Entity(x => x.PharmacyTreatmentSupplierSpecialDispensingInstructions, 15);
            Value(x => x.ActualStrength, 16);
            Entity(x => x.ActualStrengthUnit, 17);
            Value(x => x.SubstanceLotNumber, 18);
            Value(x => x.SubstanceExpirationDate, 19, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.SubstanceManufacturerName, 20);
            Entity(x => x.Indication, 21);
            Value(x => x.DispensePackageSize, 22);
            Entity(x => x.DispensePackageSizeUnit, 23);
            Value(x => x.DispensePackageMethod, 24);
            Entity(x => x.SupplementaryCode, 25);
            Entity(x => x.InitiatingLocation, 26);
            Entity(x => x.PackagingAssemblyLocation, 27);
            Value(x => x.ActualDrugStrengthVolume, 28);
            Entity(x => x.ActualDrugStrengthVolumeUnits, 29);
            Entity(x => x.DispenseToPharmacy, 30);
            Entity(x => x.DispenseToPharmacyAddress, 31);
            Value(x => x.PharmacyOrderType, 32);
            Entity(x => x.DispenseType, 33);
        }
    }
}