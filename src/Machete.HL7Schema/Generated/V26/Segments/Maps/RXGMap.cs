// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RXG (SegmentMap) - Pharmacy/Treatment Give
    /// </summary>
    public class RXGMap :
        HL7V26SegmentMap<RXG>
    {
        public RXGMap()
        {
            Id = "RXG";

            Name = "Pharmacy/Treatment Give";

            Value(x => x.GiveSubIdCounter, 1, x => {x.Required = true;});
            Value(x => x.DispenseSubIdCounter, 2);
            Entity(x => x.QuantityTiming, 3);
            Entity(x => x.GiveCode, 4, x => {x.Required = true;});
            Value(x => x.GiveAmountMinimum, 5, x => {x.Required = true;});
            Value(x => x.GiveAmountMaximum, 6);
            Entity(x => x.GiveUnits, 7, x => {x.Required = true;});
            Entity(x => x.GiveDosageForm, 8);
            Entity(x => x.AdministrationNotes, 9);
            Value(x => x.SubstitutionStatus, 10);
            Entity(x => x.DispenseToLocation, 11);
            Value(x => x.NeedHumanReview, 12);
            Entity(x => x.PharmacyTreatmentSupplierSpecialAdministrationInstructions, 13);
            Value(x => x.GivePerTimeUnit, 14);
            Value(x => x.GiveRateAmount, 15);
            Entity(x => x.GiveRateUnits, 16);
            Value(x => x.GiveStrength, 17);
            Entity(x => x.GiveStrengthUnits, 18);
            Value(x => x.SubstanceLotNumber, 19);
            Value(x => x.SubstanceExpirationDate, 20, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.SubstanceManufacturerName, 21);
            Entity(x => x.Indication, 22);
            Value(x => x.GiveDrugStrengthVolume, 23);
            Entity(x => x.GiveDrugStrengthVolumeUnits, 24);
            Entity(x => x.GiveBarcodeIdentifier, 25);
            Value(x => x.PharmacyOrderType, 26);
            Entity(x => x.DispenseToPharmacy, 27);
            Entity(x => x.DispenseToPharmacyAddress, 28);
            Entity(x => x.DeliverToPatientLocation, 29);
            Entity(x => x.DeliverToAddress, 30);
        }
    }
}