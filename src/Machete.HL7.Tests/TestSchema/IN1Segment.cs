namespace Machete.HL7.Tests.TestSchema
{
    using System;

    
    public interface IN1Segment :
        HL7Segment
    {
        Value<int> SetId { get; }
        Value<CWEComponent> InsurancePlanId { get; }
        ValueList<CXComponent> InsuranceCompanyId { get; }
        ValueList<XONComponent> InsuranceCompanyName { get; }
        ValueList<XADComponent> InsuranceCompanyAddress { get; }
        ValueList<XPNComponent> InsuranceCoContactPerson { get; }
        ValueList<XTNComponent> InsuranceCoPhoneNumber { get; }
        Value<string> GroupNumber { get; }
        ValueList<XONComponent> GroupName { get; }
        ValueList<CXComponent> InsuredSGroupEmpId { get; }
        ValueList<XONComponent> InsuredSGroupEmpName { get; }
        Value<DateTimeOffset> PlanEffectiveDate { get; }
        Value<DateTimeOffset> PlanExpirationDate { get; }
        Value<AUIComponent> AuthorizationInformation { get; }
        Value<string> PlanType { get; }
        ValueList<XPNComponent> NameOfInsured { get; }
        Value<CWEComponent> InsuredSRelationshipToPatient { get; }
        Value<DateTimeOffset> InsuredSDateOfBirth { get; }
        ValueList<XADComponent> InsuredSAddress { get; }
        Value<string> AssignmentOfBenefits { get; }
        Value<string> CoordinationOfBenefits { get; }
        Value<string> CoordOfBenPriority { get; }
        Value<string> NoticeOfAdmissionFlag { get; }
        Value<DateTimeOffset> NoticeOfAdmissionDate { get; }
        Value<string> ReportOfEligibilityFlag { get; }
        Value<DateTimeOffset> ReportOfEligibilityDate { get; }
        Value<string> ReleaseInformationCode { get; }
        Value<string> PreAdmitCert { get; }
        Value<DateTimeOffset> VerificationDateTime { get; }
        ValueList<XCNComponent> VerificationBy { get; }
        Value<string> TypeOfAgreementCode { get; }
        Value<string> BillingStatus { get; }
        Value<decimal> LifetimeReserveDays { get; }
        Value<decimal> DelayBeforeLRDay { get; }
        Value<string> CompanyPlanCode { get; }
        Value<string> PolicyNumber { get; }
        Value<CPComponent> PolicyDeductible { get; }
        Value<DateTimeOffset> PolicyLimitAmount { get; }
        Value<decimal> PolicyLimitDays { get; }
        Value<DateTimeOffset> RoomRateSemiPrivate { get; }
        Value<DateTimeOffset> RoomRatePrivate { get; }
        Value<CWEComponent> InsuredSEmploymentStatus { get; }
        Value<string> InsuredSAdministrativeSex { get; }
        ValueList<XADComponent> InsuredSEmployerSAddress { get; }
        Value<string> VerificationStatus { get; }
        Value<string> PriorInsurancePlanId { get; }
        Value<string> CoverageType { get; }
        Value<string> Handicap { get; }
        ValueList<CXComponent> InsuredSIdNumber { get; }
        Value<string> SignatureCode { get; }
        Value<DateTimeOffset> SignatureCodeDate { get; }
        Value<string> InsuredSBirthPlace { get; }
        Value<string> VIPIndicator { get; }
    }
}