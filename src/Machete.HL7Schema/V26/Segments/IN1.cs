// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// IN1 (Segment) - Insurance
    /// </summary>
    public interface IN1 :
        HL7V26Segment
    {
        /// <summary>
        /// IN1-1: Set ID - IN1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// IN1-2: Insurance Plan ID
        /// </summary>
        Value<CWE> InsurancePlanId { get; }

        /// <summary>
        /// IN1-3: Insurance Company ID
        /// </summary>
        ValueList<CX> InsuranceCompanyId { get; }

        /// <summary>
        /// IN1-4: Insurance Company Name
        /// </summary>
        ValueList<XON> InsuranceCompanyName { get; }

        /// <summary>
        /// IN1-5: Insurance Company Address
        /// </summary>
        ValueList<XAD> InsuranceCompanyAddress { get; }

        /// <summary>
        /// IN1-6: Insurance Company Contact Person
        /// </summary>
        ValueList<XPN> InsuranceCompanyContactPerson { get; }

        /// <summary>
        /// IN1-7: Insurance Company Phone Number
        /// </summary>
        ValueList<XTN> InsuranceCompanyPhoneNumber { get; }

        /// <summary>
        /// IN1-8: Group Number
        /// </summary>
        Value<string> GroupNumber { get; }

        /// <summary>
        /// IN1-9: Group Name
        /// </summary>
        ValueList<XON> GroupName { get; }

        /// <summary>
        /// IN1-10: Insured's Group Employer ID
        /// </summary>
        ValueList<CX> InsuredGroupEmployerId { get; }

        /// <summary>
        /// IN1-11: Insured's Group Employer Name
        /// </summary>
        ValueList<XON> InsuredGroupEmployerName { get; }

        /// <summary>
        /// IN1-12: Plan Effective Date
        /// </summary>
        Value<DateTimeOffset> PlanEffectiveDate { get; }

        /// <summary>
        /// IN1-13: Plan Expiration Date
        /// </summary>
        Value<DateTimeOffset> PlanExpirationDate { get; }

        /// <summary>
        /// IN1-14: Authorization Information
        /// </summary>
        Value<AUI> AuthorizationInformation { get; }

        /// <summary>
        /// IN1-15: Plan Type
        /// </summary>
        Value<string> PlanType { get; }

        /// <summary>
        /// IN1-16: Name Of Insured
        /// </summary>
        ValueList<XPN> NameOfInsured { get; }

        /// <summary>
        /// IN1-17: Insured's Relationship To Patient
        /// </summary>
        Value<CWE> InsuredRelationshipToPatient { get; }

        /// <summary>
        /// IN1-18: Insured's Date Of Birth
        /// </summary>
        Value<DateTimeOffset> InsuredDateOfBirth { get; }

        /// <summary>
        /// IN1-19: Insured's Address
        /// </summary>
        ValueList<XAD> InsuredSAddress { get; }

        /// <summary>
        /// IN1-20: Assignment Of Benefits
        /// </summary>
        Value<string> AssignmentOfBenefits { get; }

        /// <summary>
        /// IN1-21: Coordination Of Benefits
        /// </summary>
        Value<string> CoordinationOfBenefits { get; }

        /// <summary>
        /// IN1-22: Coordination Of Benefit Priority
        /// </summary>
        Value<string> CoordinationOfBenefitPriority { get; }

        /// <summary>
        /// IN1-23: Notice Of Admission Flag
        /// </summary>
        Value<string> NoticeOfAdmissionFlag { get; }

        /// <summary>
        /// IN1-24: Notice Of Admission Date
        /// </summary>
        Value<DateTimeOffset> NoticeOfAdmissionDate { get; }

        /// <summary>
        /// IN1-25: Report Of Eligibility Flag
        /// </summary>
        Value<string> ReportOfEligibilityFlag { get; }

        /// <summary>
        /// IN1-26: Report Of Eligibility Date
        /// </summary>
        Value<DateTimeOffset> ReportOfEligibilityDate { get; }

        /// <summary>
        /// IN1-27: Release Information Code
        /// </summary>
        Value<string> ReleaseInformationCode { get; }

        /// <summary>
        /// IN1-28: Pre-Admit Cert (PAC)
        /// </summary>
        Value<string> PreAdmitCert { get; }

        /// <summary>
        /// IN1-29: Verification Date/Time
        /// </summary>
        Value<DateTimeOffset> VerificationDateTime { get; }

        /// <summary>
        /// IN1-30: Verification By
        /// </summary>
        ValueList<XCN> VerificationBy { get; }

        /// <summary>
        /// IN1-31: Type Of Agreement Code
        /// </summary>
        Value<string> TypeOfAgreementCode { get; }

        /// <summary>
        /// IN1-32: Billing Status
        /// </summary>
        Value<string> BillingStatus { get; }

        /// <summary>
        /// IN1-33: Lifetime Reserve Days
        /// </summary>
        Value<decimal> LifetimeReserveDays { get; }

        /// <summary>
        /// IN1-34: Delay Before L.R. Day
        /// </summary>
        Value<decimal> DelayBeforeLRDay { get; }

        /// <summary>
        /// IN1-35: Company Plan Code
        /// </summary>
        Value<string> CompanyPlanCode { get; }

        /// <summary>
        /// IN1-36: Policy Number
        /// </summary>
        Value<string> PolicyNumber { get; }

        /// <summary>
        /// IN1-37: Policy Deductible
        /// </summary>
        Value<CP> PolicyDeductible { get; }

        /// <summary>
        /// IN1-38: Policy Limit - Amount
        /// </summary>
        Value<DateTimeOffset> PolicyLimitAmount { get; }

        /// <summary>
        /// IN1-39: Policy Limit - Days
        /// </summary>
        Value<decimal> PolicyLimitDays { get; }

        /// <summary>
        /// IN1-40: Room Rate - Semi-Private
        /// </summary>
        Value<DateTimeOffset> RoomRateSemiPrivate { get; }

        /// <summary>
        /// IN1-41: Room Rate - Private
        /// </summary>
        Value<DateTimeOffset> RoomRatePrivate { get; }

        /// <summary>
        /// IN1-42: Insured's Employment Status
        /// </summary>
        Value<CWE> InsuredEmploymentStatus { get; }

        /// <summary>
        /// IN1-43: Insured's Administrative Sex
        /// </summary>
        Value<string> InsuredAdministrativeSex { get; }

        /// <summary>
        /// IN1-44: Insured's Employer's Address
        /// </summary>
        ValueList<XAD> InsuredEmployerAddress { get; }

        /// <summary>
        /// IN1-45: Verification Status
        /// </summary>
        Value<string> VerificationStatus { get; }

        /// <summary>
        /// IN1-46: Prior Insurance Plan ID
        /// </summary>
        Value<string> PriorInsurancePlanId { get; }

        /// <summary>
        /// IN1-47: Coverage Type
        /// </summary>
        Value<string> CoverageType { get; }

        /// <summary>
        /// IN1-48: Handicap
        /// </summary>
        Value<string> Handicap { get; }

        /// <summary>
        /// IN1-49: Insured's ID Number
        /// </summary>
        ValueList<CX> InsuredIdNumber { get; }

        /// <summary>
        /// IN1-50: Signature Code
        /// </summary>
        Value<string> SignatureCode { get; }

        /// <summary>
        /// IN1-51: Signature Code Date
        /// </summary>
        Value<DateTimeOffset> SignatureCodeDate { get; }

        /// <summary>
        /// IN1-52: Insured's Birth Place
        /// </summary>
        Value<string> InsuredBirthPlace { get; }

        /// <summary>
        /// IN1-53: VIP Indicator
        /// </summary>
        Value<string> VIPIndicator { get; }
    }
}