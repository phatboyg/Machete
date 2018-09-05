// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RXO (SegmentMap) - Pharmacy/Treatment Order
    /// </summary>
    public class RXOMap :
        HL7V26SegmentMap<RXO>
    {
        public RXOMap()
        {
            Id = "RXO";

            Name = "Pharmacy/Treatment Order";

            Entity(x => x.RequestedGiveCode, 1);
            Value(x => x.RequestedGiveAmountMinimum, 2);
            Value(x => x.RequestedGiveAmountMaximum, 3);
            Entity(x => x.RequestedGiveUnits, 4);
            Entity(x => x.RequestedDosageForm, 5);
            Entity(x => x.ProviderPharmacyTreatmentInstructions, 6);
            Entity(x => x.ProviderSAdministrationInstructions, 7);
            Entity(x => x.DeliverToLocation, 8);
            Value(x => x.AllowSubstitutions, 9);
            Entity(x => x.RequestedDispenseCode, 10);
            Value(x => x.RequestedDispenseAmount, 11);
            Entity(x => x.RequestedDispenseUnits, 12);
            Value(x => x.NumberOfRefills, 13);
            Entity(x => x.OrderingProviderDEANumber, 14);
            Entity(x => x.PharmacistTreatmentSupplierVerifierId, 15);
            Value(x => x.NeedHumanReview, 16);
            Value(x => x.RequestedGivePerTimeUnit, 17);
            Value(x => x.RequestedGiveStrength, 18);
            Entity(x => x.RequestedGiveStrengthUnits, 19);
            Entity(x => x.Indication, 20);
            Value(x => x.RequestedGiveRateAmount, 21);
            Entity(x => x.RequestedGiveRateUnits, 22);
            Entity(x => x.TotalDailyDose, 23);
            Entity(x => x.SupplementaryCode, 24);
            Value(x => x.RequestedDrugStrengthVolume, 25);
            Entity(x => x.RequestedDrugStrengthVolumeUnits, 26);
            Value(x => x.PharmacyOrderType, 27);
            Value(x => x.DispensingInterval, 28);
            Entity(x => x.MedicationInstanceIdentifier, 29);
            Entity(x => x.SegmentInstanceIdentifier, 30);
            Entity(x => x.MoodCode, 31);
            Entity(x => x.DispensingPharmacy, 32);
            Entity(x => x.DispensingPharmacyAddress, 33);
            Entity(x => x.DeliverToPatientLocation, 34);
            Entity(x => x.DeliverToAddress, 35);
        }
    }
}