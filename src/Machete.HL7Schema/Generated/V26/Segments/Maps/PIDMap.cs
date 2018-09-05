// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PID (SegmentMap) - Patient Identification
    /// </summary>
    public class PIDMap :
        HL7V26SegmentMap<PID>
    {
        public PIDMap()
        {
            Id = "PID";

            Name = "Patient Identification";

            Value(x => x.SetId, 1);
            Entity(x => x.PatientId, 2);
            Entity(x => x.PatientIdentifierList, 3, x => x.IsRequired());
            Entity(x => x.AlternatePatientId, 4);
            Entity(x => x.PatientName, 5, x => x.IsRequired());
            Entity(x => x.MotherSMaidenName, 6);
            Value(x => x.DateTimeOfBirth, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.AdministrativeSex, 8);
            Entity(x => x.PatientAlias, 9);
            Entity(x => x.Race, 10);
            Entity(x => x.PatientAddress, 11);
            Value(x => x.CountyCode, 12);
            Entity(x => x.PhoneNumberHome, 13);
            Entity(x => x.PhoneNumberBusiness, 14);
            Entity(x => x.PrimaryLanguage, 15);
            Entity(x => x.MaritalStatus, 16);
            Entity(x => x.Religion, 17);
            Entity(x => x.PatientAccountNumber, 18);
            Value(x => x.SSNNumberPatient, 19);
            Entity(x => x.DriverSLicenseNumberPatient, 20);
            Entity(x => x.MotherSIdentifier, 21);
            Entity(x => x.EthnicGroup, 22);
            Value(x => x.BirthPlace, 23);
            Value(x => x.MultipleBirthIndicator, 24);
            Value(x => x.BirthOrder, 25);
            Entity(x => x.Citizenship, 26);
            Entity(x => x.VeteranMilitaryStatus, 27);
            Entity(x => x.Nationality, 28);
            Value(x => x.PatientDeathDateAndTime, 29, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.PatientDeathIndicator, 30);
            Value(x => x.IdentityUnknownIndicator, 31);
            Value(x => x.IdentityReliabilityCode, 32);
            Value(x => x.LastUpdateDateTime, 33, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.LastUpdateFacility, 34);
            Entity(x => x.SpecieCode, 35);
            Entity(x => x.BreedCode, 36);
            Value(x => x.Strain, 37);
            Entity(x => x.ProductionClassCode, 38);
            Entity(x => x.TribalCitizenship, 39);
        }
    }
}