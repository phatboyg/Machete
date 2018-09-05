// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// STF (SegmentMap) - Staff Identification
    /// </summary>
    public class STFMap :
        HL7V26SegmentMap<STF>
    {
        public STFMap()
        {
            Id = "STF";

            Name = "Staff Identification";

            Entity(x => x.PrimaryKeyValue, 1);
            Entity(x => x.StaffIdentifierList, 2);
            Entity(x => x.StaffName, 3);
            Value(x => x.StaffType, 4);
            Value(x => x.AdministrativeSex, 5);
            Value(x => x.DateTimeOfBirth, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ActiveInactiveFlag, 7);
            Entity(x => x.Department, 8);
            Entity(x => x.HospitalService, 9);
            Entity(x => x.Phone, 10);
            Entity(x => x.OfficeHomeAddressBirthplace, 11);
            Entity(x => x.InstitutionActivationDate, 12);
            Entity(x => x.InstitutionInactivationDate, 13);
            Entity(x => x.BackupPersonId, 14);
            Value(x => x.EMailAddress, 15);
            Entity(x => x.PreferredMethodOfContact, 16);
            Entity(x => x.MaritalStatus, 17);
            Value(x => x.JobTitle, 18);
            Entity(x => x.JobCodeClass, 19);
            Entity(x => x.EmploymentStatusCode, 20);
            Value(x => x.AdditionalInsuredOnAuto, 21);
            Entity(x => x.DriverSLicenseNumberStaff, 22);
            Value(x => x.CopyAutoIns, 23);
            Value(x => x.AutoInsExpires, 24, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.DateLastDMVReview, 25, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.DateNextDMVReview, 26, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.Race, 27);
            Entity(x => x.EthnicGroup, 28);
            Value(x => x.ReActivationApprovalIndicator, 29);
            Entity(x => x.Citizenship, 30);
            Value(x => x.DateTimeOfDeath, 31, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.DeathIndicator, 32);
            Entity(x => x.InstitutionRelationshipTypeCode, 33);
            Entity(x => x.InstitutionRelationshipPeriod, 34);
            Value(x => x.ExpectedReturnDate, 35, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.CostCenterCode, 36);
            Value(x => x.GenericClassificationIndicator, 37);
            Entity(x => x.InactiveReasonCode, 38);
            Entity(x => x.GenericResourceTypeOrCategory, 39);
        }
    }
}