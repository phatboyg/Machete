// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// IN2 (SegmentMap) - Insurance Additional Information
    /// </summary>
    public class IN2Map :
        HL7V26SegmentMap<IN2>
    {
        public IN2Map()
        {
            Id = "IN2";

            Name = "Insurance Additional Information";

            Entity(x => x.InsuredEmployeeId, 1);
            Value(x => x.InsuredSocialSecurityNumber, 2);
            Entity(x => x.InsuredEmployerNameAndId, 3);
            Value(x => x.EmployerInformationData, 4);
            Value(x => x.MailClaimParty, 5);
            Value(x => x.MedicareHealthInsCardNumber, 6);
            Entity(x => x.MedicaidCaseName, 7);
            Value(x => x.MedicaidCaseNumber, 8);
            Entity(x => x.MilitarySponsorName, 9);
            Value(x => x.MilitaryIdNumber, 10);
            Entity(x => x.DependentOfMilitaryRecipient, 11);
            Value(x => x.MilitaryOrganization, 12);
            Value(x => x.MilitaryStation, 13);
            Value(x => x.MilitaryService, 14);
            Value(x => x.MilitaryRankGrade, 15);
            Value(x => x.MilitaryStatus, 16);
            Value(x => x.MilitaryRetireDate, 17, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.MilitaryNonAvailCertOnFile, 18);
            Value(x => x.BabyCoverage, 19);
            Value(x => x.CombineBabyBill, 20);
            Value(x => x.BloodDeductible, 21);
            Entity(x => x.SpecialCoverageApprovalName, 22);
            Value(x => x.SpecialCoverageApprovalTitle, 23);
            Value(x => x.NonCoveredInsuranceCode, 24);
            Entity(x => x.PayorId, 25);
            Entity(x => x.PayorSubscriberId, 26);
            Value(x => x.EligibilitySource, 27);
            Entity(x => x.RoomCoverageTypeAmount, 28);
            Entity(x => x.PolicyTypeAmount, 29);
            Entity(x => x.DailyDeductible, 30);
            Value(x => x.LivingDependency, 31);
            Value(x => x.AmbulatoryStatus, 32);
            Entity(x => x.Citizenship, 33);
            Entity(x => x.PrimaryLanguage, 34);
            Value(x => x.LivingArrangement, 35);
            Entity(x => x.PublicityCode, 36);
            Value(x => x.ProtectionIndicator, 37);
            Value(x => x.StudentIndicator, 38);
            Entity(x => x.Religion, 39);
            Entity(x => x.MotherMaidenName, 40);
            Entity(x => x.Nationality, 41);
            Entity(x => x.EthnicGroup, 42);
            Entity(x => x.MaritalStatus, 43);
            Value(x => x.InsuredEmploymentStartDate, 44, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.EmploymentStopDate, 45, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.JobTitle, 46);
            Entity(x => x.JobCodeClass, 47);
            Value(x => x.JobStatus, 48);
            Entity(x => x.EmployerContactPersonName, 49);
            Entity(x => x.EmployerContactPersonPhoneNumber, 50);
            Value(x => x.EmployerContactReason, 51);
            Entity(x => x.InsuredContactPersonSName, 52);
            Entity(x => x.InsuredContactPersonPhoneNumber, 53);
            Value(x => x.InsuredContactPersonReason, 54);
            Value(x => x.RelationshipToPatientStartDate, 55, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.RelationshipToPatientStopDate, 56, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.InsuranceCompanyContactReason, 57);
            Entity(x => x.InsuranceCompanyContactPhoneNumber, 58);
            Value(x => x.PolicyScope, 59);
            Value(x => x.PolicySource, 60);
            Entity(x => x.PatientMemberNumber, 61);
            Entity(x => x.GuarantorRelationshipToInsured, 62);
            Entity(x => x.InsuredPhoneNumberHome, 63);
            Entity(x => x.InsuredEmployerPhoneNumber, 64);
            Entity(x => x.MilitaryHandicappedProgram, 65);
            Value(x => x.SuspendFlag, 66);
            Value(x => x.CopayLimitFlag, 67);
            Value(x => x.StopLossLimitFlag, 68);
            Entity(x => x.InsuredOrganizationNameAndId, 69);
            Entity(x => x.InsuredEmployerOrganizationNameAndId, 70);
            Entity(x => x.Race, 71);
            Entity(x => x.PatientRelationshipToInsured, 72);
        }
    }
}