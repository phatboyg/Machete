// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// IN2 (Segment) - Insurance Additional Information
    /// </summary>
    public interface IN2 :
        HL7V26Segment
    {
        /// <summary>
        /// IN2-1: Insured's Employee ID
        /// </summary>
        ValueList<CX> InsuredEmployeeId { get; }

        /// <summary>
        /// IN2-2: Insured's Social Security Number
        /// </summary>
        Value<string> InsuredSocialSecurityNumber { get; }

        /// <summary>
        /// IN2-3: Insured's Employer's Name and ID
        /// </summary>
        ValueList<XCN> InsuredEmployerNameAndId { get; }

        /// <summary>
        /// IN2-4: Employer Information Data
        /// </summary>
        Value<string> EmployerInformationData { get; }

        /// <summary>
        /// IN2-5: Mail Claim Party
        /// </summary>
        ValueList<string> MailClaimParty { get; }

        /// <summary>
        /// IN2-6: Medicare Health Ins Card Number
        /// </summary>
        Value<string> MedicareHealthInsCardNumber { get; }

        /// <summary>
        /// IN2-7: Medicaid Case Name
        /// </summary>
        ValueList<XPN> MedicaidCaseName { get; }

        /// <summary>
        /// IN2-8: Medicaid Case Number
        /// </summary>
        Value<string> MedicaidCaseNumber { get; }

        /// <summary>
        /// IN2-9: Military Sponsor Name
        /// </summary>
        ValueList<XPN> MilitarySponsorName { get; }

        /// <summary>
        /// IN2-10: Military ID Number
        /// </summary>
        Value<string> MilitaryIdNumber { get; }

        /// <summary>
        /// IN2-11: Dependent Of Military Recipient
        /// </summary>
        Value<CWE> DependentOfMilitaryRecipient { get; }

        /// <summary>
        /// IN2-12: Military Organization
        /// </summary>
        Value<string> MilitaryOrganization { get; }

        /// <summary>
        /// IN2-13: Military Station
        /// </summary>
        Value<string> MilitaryStation { get; }

        /// <summary>
        /// IN2-14: Military Service
        /// </summary>
        Value<string> MilitaryService { get; }

        /// <summary>
        /// IN2-15: Military Rank/Grade
        /// </summary>
        Value<string> MilitaryRankGrade { get; }

        /// <summary>
        /// IN2-16: Military Status
        /// </summary>
        Value<string> MilitaryStatus { get; }

        /// <summary>
        /// IN2-17: Military Retire Date
        /// </summary>
        Value<DateTimeOffset> MilitaryRetireDate { get; }

        /// <summary>
        /// IN2-18: Military Non-Avail Cert On File
        /// </summary>
        Value<string> MilitaryNonAvailCertOnFile { get; }

        /// <summary>
        /// IN2-19: Baby Coverage
        /// </summary>
        Value<string> BabyCoverage { get; }

        /// <summary>
        /// IN2-20: Combine Baby Bill
        /// </summary>
        Value<string> CombineBabyBill { get; }

        /// <summary>
        /// IN2-21: Blood Deductible
        /// </summary>
        Value<string> BloodDeductible { get; }

        /// <summary>
        /// IN2-22: Special Coverage Approval Name
        /// </summary>
        ValueList<XPN> SpecialCoverageApprovalName { get; }

        /// <summary>
        /// IN2-23: Special Coverage Approval Title
        /// </summary>
        Value<string> SpecialCoverageApprovalTitle { get; }

        /// <summary>
        /// IN2-24: Non-Covered Insurance Code
        /// </summary>
        ValueList<string> NonCoveredInsuranceCode { get; }

        /// <summary>
        /// IN2-25: Payor ID
        /// </summary>
        ValueList<CX> PayorId { get; }

        /// <summary>
        /// IN2-26: Payor Subscriber ID
        /// </summary>
        ValueList<CX> PayorSubscriberId { get; }

        /// <summary>
        /// IN2-27: Eligibility Source
        /// </summary>
        Value<string> EligibilitySource { get; }

        /// <summary>
        /// IN2-28: Room Coverage Type/Amount
        /// </summary>
        ValueList<RMC> RoomCoverageTypeAmount { get; }

        /// <summary>
        /// IN2-29: Policy Type/Amount
        /// </summary>
        ValueList<PTA> PolicyTypeAmount { get; }

        /// <summary>
        /// IN2-30: Daily Deductible
        /// </summary>
        Value<DDI> DailyDeductible { get; }

        /// <summary>
        /// IN2-31: Living Dependency
        /// </summary>
        Value<string> LivingDependency { get; }

        /// <summary>
        /// IN2-32: Ambulatory Status
        /// </summary>
        ValueList<string> AmbulatoryStatus { get; }

        /// <summary>
        /// IN2-33: Citizenship
        /// </summary>
        ValueList<CWE> Citizenship { get; }

        /// <summary>
        /// IN2-34: Primary Language
        /// </summary>
        Value<CWE> PrimaryLanguage { get; }

        /// <summary>
        /// IN2-35: Living Arrangement
        /// </summary>
        Value<string> LivingArrangement { get; }

        /// <summary>
        /// IN2-36: Publicity Code
        /// </summary>
        Value<CWE> PublicityCode { get; }

        /// <summary>
        /// IN2-37: Protection Indicator
        /// </summary>
        Value<string> ProtectionIndicator { get; }

        /// <summary>
        /// IN2-38: Student Indicator
        /// </summary>
        Value<string> StudentIndicator { get; }

        /// <summary>
        /// IN2-39: Religion
        /// </summary>
        Value<CWE> Religion { get; }

        /// <summary>
        /// IN2-40: Mother's Maiden Name
        /// </summary>
        ValueList<XPN> MotherMaidenName { get; }

        /// <summary>
        /// IN2-41: Nationality
        /// </summary>
        Value<CWE> Nationality { get; }

        /// <summary>
        /// IN2-42: Ethnic Group
        /// </summary>
        ValueList<CWE> EthnicGroup { get; }

        /// <summary>
        /// IN2-43: Marital Status
        /// </summary>
        ValueList<CWE> MaritalStatus { get; }

        /// <summary>
        /// IN2-44: Insured's Employment Start Date
        /// </summary>
        Value<DateTimeOffset> InsuredEmploymentStartDate { get; }

        /// <summary>
        /// IN2-45: Employment Stop Date
        /// </summary>
        Value<DateTimeOffset> EmploymentStopDate { get; }

        /// <summary>
        /// IN2-46: Job Title
        /// </summary>
        Value<string> JobTitle { get; }

        /// <summary>
        /// IN2-47: Job Code/Class
        /// </summary>
        Value<JCC> JobCodeClass { get; }

        /// <summary>
        /// IN2-48: Job Status
        /// </summary>
        Value<string> JobStatus { get; }

        /// <summary>
        /// IN2-49: Employer Contact Person Name
        /// </summary>
        ValueList<XPN> EmployerContactPersonName { get; }

        /// <summary>
        /// IN2-50: Employer Contact Person Phone Number
        /// </summary>
        ValueList<XTN> EmployerContactPersonPhoneNumber { get; }

        /// <summary>
        /// IN2-51: Employer Contact Reason
        /// </summary>
        Value<string> EmployerContactReason { get; }

        /// <summary>
        /// IN2-52: Insured's Contact Person's Name
        /// </summary>
        ValueList<XPN> InsuredContactPersonSName { get; }

        /// <summary>
        /// IN2-53: Insured's Contact Person Phone Number
        /// </summary>
        ValueList<XTN> InsuredContactPersonPhoneNumber { get; }

        /// <summary>
        /// IN2-54: Insured's Contact Person Reason
        /// </summary>
        ValueList<string> InsuredContactPersonReason { get; }

        /// <summary>
        /// IN2-55: Relationship to the Patient Start Date
        /// </summary>
        Value<DateTimeOffset> RelationshipToPatientStartDate { get; }

        /// <summary>
        /// IN2-56: Relationship to the Patient Stop Date
        /// </summary>
        ValueList<DateTimeOffset> RelationshipToPatientStopDate { get; }

        /// <summary>
        /// IN2-57: Insurance Company Contact Reason
        /// </summary>
        Value<string> InsuranceCompanyContactReason { get; }

        /// <summary>
        /// IN2-58: Insurance Company Contact Phone Number
        /// </summary>
        ValueList<XTN> InsuranceCompanyContactPhoneNumber { get; }

        /// <summary>
        /// IN2-59: Policy Scope
        /// </summary>
        Value<string> PolicyScope { get; }

        /// <summary>
        /// IN2-60: Policy Source
        /// </summary>
        Value<string> PolicySource { get; }

        /// <summary>
        /// IN2-61: Patient Member Number
        /// </summary>
        Value<CX> PatientMemberNumber { get; }

        /// <summary>
        /// IN2-62: Guarantor's Relationship to Insured
        /// </summary>
        Value<CWE> GuarantorRelationshipToInsured { get; }

        /// <summary>
        /// IN2-63: Insured's Phone Number - Home
        /// </summary>
        ValueList<XTN> InsuredPhoneNumberHome { get; }

        /// <summary>
        /// IN2-64: Insured's Employer Phone Number
        /// </summary>
        ValueList<XTN> InsuredEmployerPhoneNumber { get; }

        /// <summary>
        /// IN2-65: Military Handicapped Program
        /// </summary>
        Value<CWE> MilitaryHandicappedProgram { get; }

        /// <summary>
        /// IN2-66: Suspend Flag
        /// </summary>
        Value<string> SuspendFlag { get; }

        /// <summary>
        /// IN2-67: Copay Limit Flag
        /// </summary>
        Value<string> CopayLimitFlag { get; }

        /// <summary>
        /// IN2-68: Stop/Loss Limit Flag
        /// </summary>
        Value<string> StopLossLimitFlag { get; }

        /// <summary>
        /// IN2-69: Insured Organization Name and ID
        /// </summary>
        ValueList<XON> InsuredOrganizationNameAndId { get; }

        /// <summary>
        /// IN2-70: Insured Employer Organization Name and ID
        /// </summary>
        ValueList<XON> InsuredEmployerOrganizationNameAndId { get; }

        /// <summary>
        /// IN2-71: Race
        /// </summary>
        ValueList<CWE> Race { get; }

        /// <summary>
        /// IN2-72: Patient's Relationship to Insured
        /// </summary>
        Value<CWE> PatientRelationshipToInsured { get; }
    }
}