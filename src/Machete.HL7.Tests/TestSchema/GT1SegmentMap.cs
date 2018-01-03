namespace Machete.HL7.Tests.TestSchema
{
    public class GT1SegmentMap :
        HL7SegmentMap<GT1Segment, HL7Entity>
    {
        public GT1SegmentMap()
        {
            Id = "GT1";

            Name = "Guarantor";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Entity(x => x.GuarantorNumber, 2);
            Entity(x => x.GuarantorName, 3, x => {x.Required = true;});
            Entity(x => x.GuarantorSpouseName, 4);
            Entity(x => x.GuarantorAddress, 5);
            Entity(x => x.GuarantorPhNumHome, 6);
            Entity(x => x.GuarantorPhNumBusiness, 7);
            Value(x => x.GuarantorDateTimeOfBirth, 8, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.GuarantorAdministrativeSex, 9);
            Value(x => x.GuarantorType, 10);
            Entity(x => x.GuarantorRelationship, 11);
            Value(x => x.GuarantorSSN, 12);
            Value(x => x.GuarantorDateBegin, 13, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.GuarantorDateEnd, 14, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.GuarantorPriority, 15);
            Entity(x => x.GuarantorEmployerName, 16);
            Entity(x => x.GuarantorEmployerAddress, 17);
            Entity(x => x.GuarantorEmployerPhoneNumber, 18);
            Entity(x => x.GuarantorEmployeeIdNumber, 19);
            Value(x => x.GuarantorEmploymentStatus, 20);
            Entity(x => x.GuarantorOrganizationName, 21);
            Value(x => x.GuarantorBillingHoldFlag, 22);
            Entity(x => x.GuarantorCreditRatingCode, 23);
            Value(x => x.GuarantorDeathDateAndTime, 24, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.GuarantorDeathFlag, 25);
            Entity(x => x.GuarantorChargeAdjustmentCode, 26);
            Entity(x => x.GuarantorHouseholdAnnualIncome, 27);
            Value(x => x.GuarantorHouseholdSize, 28);
            Entity(x => x.GuarantorEmployerIdNumber, 29);
            Entity(x => x.GuarantorMaritalStatusCode, 30);
            Value(x => x.GuarantorHireEffectiveDate, 31, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.EmploymentStopDate, 32, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.LivingDependency, 33);
            Value(x => x.AmbulatoryStatus, 34);
            Entity(x => x.Citizenship, 35);
            Entity(x => x.PrimaryLanguage, 36);
            Value(x => x.LivingArrangement, 37);
            Entity(x => x.PublicityCode, 38);
            Value(x => x.ProtectionIndicator, 39);
            Value(x => x.StudentIndicator, 40);
            Entity(x => x.Religion, 41);
            Entity(x => x.MotherSMaidenName, 42);
            Entity(x => x.Nationality, 43);
            Entity(x => x.EthnicGroup, 44);
            Entity(x => x.ContactPersonSName, 45);
            Entity(x => x.ContactPersonSTelephoneNumber, 46);
            Entity(x => x.ContactReason, 47);
            Value(x => x.ContactRelationship, 48);
            Value(x => x.JobTitle, 49);
            Entity(x => x.JobCodeClass, 50);
            Entity(x => x.GuarantorEmployerSOrganizationName, 51);
            Value(x => x.Handicap, 52);
            Value(x => x.JobStatus, 53);
            Entity(x => x.GuarantorFinancialClass, 54);
            Entity(x => x.GuarantorRace, 55);
            Value(x => x.GuarantorBirthPlace, 56);
            Value(x => x.VIPIndicator, 57);
        }
    }
}