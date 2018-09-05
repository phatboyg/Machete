// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NK1 (SegmentMap) - Next of Kin / Associated Parties
    /// </summary>
    public class NK1Map :
        HL7V26SegmentMap<NK1>
    {
        public NK1Map()
        {
            Id = "NK1";

            Name = "Next of Kin / Associated Parties";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Entity(x => x.Name, 2);
            Entity(x => x.Relationship, 3);
            Entity(x => x.Address, 4);
            Entity(x => x.PhoneNumber, 5);
            Entity(x => x.BusinessPhoneNumber, 6);
            Entity(x => x.ContactRole, 7);
            Value(x => x.StartDate, 8, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.EndDate, 9, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.NextOfKinAssociatedPartiesJobTitle, 10);
            Entity(x => x.NextOfKinAssociatedPartiesJobCodeClass, 11);
            Entity(x => x.NextOfKinAssociatedPartiesEmployeeNumber, 12);
            Entity(x => x.OrganizationName, 13);
            Entity(x => x.MaritalStatus, 14);
            Value(x => x.AdministrativeSex, 15);
            Value(x => x.DateTimeOfBirth, 16, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.LivingDependency, 17);
            Value(x => x.AmbulatoryStatus, 18);
            Entity(x => x.Citizenship, 19);
            Entity(x => x.PrimaryLanguage, 20);
            Value(x => x.LivingArrangement, 21);
            Entity(x => x.PublicityCode, 22);
            Value(x => x.ProtectionIndicator, 23);
            Value(x => x.StudentIndicator, 24);
            Entity(x => x.Religion, 25);
            Entity(x => x.MotherSMaidenName, 26);
            Entity(x => x.Nationality, 27);
            Entity(x => x.EthnicGroup, 28);
            Entity(x => x.ContactReason, 29);
            Entity(x => x.ContactPersonSName, 30);
            Entity(x => x.ContactPersonSTelephoneNumber, 31);
            Entity(x => x.ContactPersonSAddress, 32);
            Entity(x => x.NextOfKinAssociatedPartySIdentifiers, 33);
            Value(x => x.JobStatus, 34);
            Entity(x => x.Race, 35);
            Value(x => x.Handicap, 36);
            Value(x => x.ContactPersonSocialSecurityNumber, 37);
            Value(x => x.NextOfKinBirthPlace, 38);
            Value(x => x.VIPIndicator, 39);
        }
    }
}