// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RXA (SegmentMap) - Pharmacy/Treatment Administration
    /// </summary>
    public class RXAMap :
        HL7V26SegmentMap<RXA>
    {
        public RXAMap()
        {
            Id = "RXA";

            Name = "Pharmacy/Treatment Administration";

            Value(x => x.GiveSubIdCounter, 1, x => x.IsRequired());
            Value(x => x.AdministrationSubIdCounter, 2, x => x.IsRequired());
            Value(x => x.DateTimeStartOfAdministration, 3, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Value(x => x.DateTimeEndOfAdministration, 4, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.AdministeredCode, 5, x => x.IsRequired());
            Value(x => x.AdministeredAmount, 6, x => x.IsRequired());
            Entity(x => x.AdministeredUnits, 7);
            Entity(x => x.AdministeredDosageForm, 8);
            Entity(x => x.AdministrationNotes, 9);
            Entity(x => x.AdministeringProvider, 10);
            Entity(x => x.AdministeredAtLocation, 11);
            Value(x => x.AdministeredPerTimeUnit, 12);
            Value(x => x.AdministeredStrength, 13);
            Entity(x => x.AdministeredStrengthUnits, 14);
            Value(x => x.SubstanceLotNumber, 15);
            Value(x => x.SubstanceExpirationDate, 16, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.SubstanceManufacturerName, 17);
            Entity(x => x.SubstanceTreatmentRefusalReason, 18);
            Entity(x => x.Indication, 19);
            Value(x => x.CompletionStatus, 20);
            Value(x => x.ActionCode, 21);
            Value(x => x.SystemEntryDateTime, 22, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.AdministeredDrugStrengthVolume, 23);
            Entity(x => x.AdministeredDrugStrengthVolumeUnits, 24);
            Entity(x => x.AdministeredBarcodeIdentifier, 25);
            Value(x => x.PharmacyOrderType, 26);
            Entity(x => x.AdministerAt, 27);
            Entity(x => x.AdministeredAtAddress, 28);
        }
    }
}