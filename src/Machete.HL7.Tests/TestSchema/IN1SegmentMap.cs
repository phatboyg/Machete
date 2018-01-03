namespace Machete.HL7.Tests.TestSchema
{
    public class IN1SegmentMap :
        HL7SegmentMap<IN1Segment, HL7Entity>
    {
        public IN1SegmentMap()
        {
            Id = "IN1";

            Name = "Insurance";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Entity(x => x.InsurancePlanId, 2, x => {x.Required = true;});
            Entity(x => x.InsuranceCompanyId, 3, x => {x.Required = true;});
            Entity(x => x.InsuranceCompanyName, 4);
            Entity(x => x.InsuranceCompanyAddress, 5);
            Entity(x => x.InsuranceCoContactPerson, 6);
            Entity(x => x.InsuranceCoPhoneNumber, 7);
            Value(x => x.GroupNumber, 8);
            Entity(x => x.GroupName, 9);
            Entity(x => x.InsuredSGroupEmpId, 10);
            Entity(x => x.InsuredSGroupEmpName, 11);
            Value(x => x.PlanEffectiveDate, 12, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.PlanExpirationDate, 13, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.AuthorizationInformation, 14);
            Value(x => x.PlanType, 15);
            Entity(x => x.NameOfInsured, 16);
            Entity(x => x.InsuredSRelationshipToPatient, 17);
            Value(x => x.InsuredSDateOfBirth, 18, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.InsuredSAddress, 19);
            Value(x => x.AssignmentOfBenefits, 20);
            Value(x => x.CoordinationOfBenefits, 21);
            Value(x => x.CoordOfBenPriority, 22);
            Value(x => x.NoticeOfAdmissionFlag, 23);
            Value(x => x.NoticeOfAdmissionDate, 24, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ReportOfEligibilityFlag, 25);
            Value(x => x.ReportOfEligibilityDate, 26, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ReleaseInformationCode, 27);
            Value(x => x.PreAdmitCert, 28);
            Value(x => x.VerificationDateTime, 29, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.VerificationBy, 30);
            Value(x => x.TypeOfAgreementCode, 31);
            Value(x => x.BillingStatus, 32);
            Value(x => x.LifetimeReserveDays, 33);
            Value(x => x.DelayBeforeLRDay, 34);
            Value(x => x.CompanyPlanCode, 35);
            Value(x => x.PolicyNumber, 36);
            Entity(x => x.PolicyDeductible, 37);
            Value(x => x.PolicyLimitAmount, 38, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.PolicyLimitDays, 39);
            Value(x => x.RoomRateSemiPrivate, 40, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.RoomRatePrivate, 41, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.InsuredSEmploymentStatus, 42);
            Value(x => x.InsuredSAdministrativeSex, 43);
            Entity(x => x.InsuredSEmployerSAddress, 44);
            Value(x => x.VerificationStatus, 45);
            Value(x => x.PriorInsurancePlanId, 46);
            Value(x => x.CoverageType, 47);
            Value(x => x.Handicap, 48);
            Entity(x => x.InsuredSIdNumber, 49);
            Value(x => x.SignatureCode, 50);
            Value(x => x.SignatureCodeDate, 51, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.InsuredSBirthPlace, 52);
            Value(x => x.VIPIndicator, 53);
        }
    }
}