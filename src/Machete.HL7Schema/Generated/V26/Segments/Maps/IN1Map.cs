// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// IN1 (SegmentMap) - Insurance
    /// </summary>
    public class IN1Map :
        HL7V26SegmentMap<IN1>
    {
        public IN1Map()
        {
            Id = "IN1";

            Name = "Insurance";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Entity(x => x.InsurancePlanId, 2, x => {x.Required = true;});
            Entity(x => x.InsuranceCompanyId, 3, x => {x.Required = true;});
            Entity(x => x.InsuranceCompanyName, 4);
            Entity(x => x.InsuranceCompanyAddress, 5);
            Entity(x => x.InsuranceCompanyContactPerson, 6);
            Entity(x => x.InsuranceCompanyPhoneNumber, 7);
            Value(x => x.GroupNumber, 8);
            Entity(x => x.GroupName, 9);
            Entity(x => x.InsuredGroupEmployerId, 10);
            Entity(x => x.InsuredGroupEmployerName, 11);
            Value(x => x.PlanEffectiveDate, 12, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.PlanExpirationDate, 13, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.AuthorizationInformation, 14);
            Value(x => x.PlanType, 15);
            Entity(x => x.NameOfInsured, 16);
            Entity(x => x.InsuredRelationshipToPatient, 17);
            Value(x => x.InsuredDateOfBirth, 18, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.InsuredSAddress, 19);
            Value(x => x.AssignmentOfBenefits, 20);
            Value(x => x.CoordinationOfBenefits, 21);
            Value(x => x.CoordinationOfBenefitPriority, 22);
            Value(x => x.NoticeOfAdmissionFlag, 23);
            Value(x => x.NoticeOfAdmissionDate, 24, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ReportOfEligibilityFlag, 25);
            Value(x => x.ReportOfEligibilityDate, 26, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ReleaseInformationCode, 27);
            Value(x => x.PreAdmitCert, 28);
            Value(x => x.VerificationDateTime, 29, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.VerificationBy, 30);
            Value(x => x.TypeOfAgreementCode, 31);
            Value(x => x.BillingStatus, 32);
            Value(x => x.LifetimeReserveDays, 33);
            Value(x => x.DelayBeforeLRDay, 34);
            Value(x => x.CompanyPlanCode, 35);
            Value(x => x.PolicyNumber, 36);
            Entity(x => x.PolicyDeductible, 37);
            Value(x => x.PolicyLimitAmount, 38, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.PolicyLimitDays, 39);
            Value(x => x.RoomRateSemiPrivate, 40, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.RoomRatePrivate, 41, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.InsuredEmploymentStatus, 42);
            Value(x => x.InsuredAdministrativeSex, 43);
            Entity(x => x.InsuredEmployerAddress, 44);
            Value(x => x.VerificationStatus, 45);
            Value(x => x.PriorInsurancePlanId, 46);
            Value(x => x.CoverageType, 47);
            Value(x => x.Handicap, 48);
            Entity(x => x.InsuredIdNumber, 49);
            Value(x => x.SignatureCode, 50);
            Value(x => x.SignatureCodeDate, 51, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.InsuredBirthPlace, 52);
            Value(x => x.VIPIndicator, 53);
        }
    }
}