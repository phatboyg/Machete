// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RXE (SegmentMap) - Pharmacy/Treatment Encoded Order
    /// </summary>
    public class RXEMap :
        HL7V26SegmentMap<RXE>
    {
        public RXEMap()
        {
            Id = "RXE";

            Name = "Pharmacy/Treatment Encoded Order";

            Entity(x => x.QuantityTiming, 1);
            Entity(x => x.GiveCode, 2, x => {x.Required = true;});
            Value(x => x.GiveAmountMinimum, 3, x => {x.Required = true;});
            Value(x => x.GiveAmountMaximum, 4);
            Entity(x => x.GiveUnits, 5, x => {x.Required = true;});
            Entity(x => x.GiveDosageForm, 6);
            Entity(x => x.ProviderAdministrationInstructions, 7);
            Entity(x => x.DeliverToLocation, 8);
            Value(x => x.SubstitutionStatus, 9);
            Value(x => x.DispenseAmount, 10);
            Entity(x => x.DispenseUnits, 11);
            Value(x => x.NumberOfRefills, 12);
            Entity(x => x.OrderingProviderDEANumber, 13);
            Entity(x => x.PharmacistTreatmentSupplierVerifierId, 14);
            Value(x => x.PrescriptionNumber, 15);
            Value(x => x.NumberOfRefillsRemaining, 16);
            Value(x => x.NumberOfRefillsDosesDispensed, 17);
            Value(x => x.DTOfMostRecentRefillOrDoseDispensed, 18, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.TotalDailyDose, 19);
            Value(x => x.NeedHumanReview, 20);
            Entity(x => x.PharmacyTreatmentSupplierSpecialDispensingInstructions, 21);
            Value(x => x.GivePerTimeUnit, 22);
            Value(x => x.GiveRateAmount, 23);
            Entity(x => x.GiveRateUnits, 24);
            Value(x => x.GiveStrength, 25);
            Entity(x => x.GiveStrengthUnits, 26);
            Entity(x => x.GiveIndication, 27);
            Value(x => x.DispensePackageSize, 28);
            Entity(x => x.DispensePackageSizeUnit, 29);
            Value(x => x.DispensePackageMethod, 30);
            Entity(x => x.SupplementaryCode, 31);
            Value(x => x.OriginalOrderDateTime, 32, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.GiveDrugStrengthVolume, 33);
            Entity(x => x.GiveDrugStrengthVolumeUnits, 34);
            Entity(x => x.ControlledSubstanceSchedule, 35);
            Value(x => x.FormularyStatus, 36);
            Entity(x => x.PharmaceuticalSubstanceAlternative, 37);
            Entity(x => x.PharmacyOfMostRecentFill, 38);
            Value(x => x.InitialDispenseAmount, 39);
            Entity(x => x.DispensingPharmacy, 40);
            Entity(x => x.DispensingPharmacyAddress, 41);
            Entity(x => x.DeliverToPatientLocation, 42);
            Entity(x => x.DeliverToAddress, 43);
            Value(x => x.PharmacyOrderType, 44);
        }
    }
}