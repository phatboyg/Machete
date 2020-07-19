// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// GT1 (Segment) - Guarantor
    /// </summary>
    public interface GT1 :
        HL7V26Segment
    {
        /// <summary>
        /// GT1-1: Set ID - GT1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// GT1-2: Guarantor Number
        /// </summary>
        ValueList<CX> GuarantorNumber { get; }

        /// <summary>
        /// GT1-3: Guarantor Name
        /// </summary>
        ValueList<XPN> GuarantorName { get; }

        /// <summary>
        /// GT1-4: Guarantor Spouse Name
        /// </summary>
        ValueList<XPN> GuarantorSpouseName { get; }

        /// <summary>
        /// GT1-5: Guarantor Address
        /// </summary>
        ValueList<XAD> GuarantorAddress { get; }

        /// <summary>
        /// GT1-6: Guarantor Ph Num - Home
        /// </summary>
        ValueList<XTN> GuarantorPhNumHome { get; }

        /// <summary>
        /// GT1-7: Guarantor Ph Num - Business
        /// </summary>
        ValueList<XTN> GuarantorPhNumBusiness { get; }

        /// <summary>
        /// GT1-8: Guarantor Date/Time Of Birth
        /// </summary>
        Value<DateTimeOffset> GuarantorDateTimeOfBirth { get; }

        /// <summary>
        /// GT1-9: Guarantor Administrative Sex
        /// </summary>
        Value<string> GuarantorAdministrativeSex { get; }

        /// <summary>
        /// GT1-10: Guarantor Type
        /// </summary>
        Value<string> GuarantorType { get; }

        /// <summary>
        /// GT1-11: Guarantor Relationship
        /// </summary>
        Value<CWE> GuarantorRelationship { get; }

        /// <summary>
        /// GT1-12: Guarantor SSN
        /// </summary>
        Value<string> GuarantorSSN { get; }

        /// <summary>
        /// GT1-13: Guarantor Date - Begin
        /// </summary>
        Value<DateTimeOffset> GuarantorDateBegin { get; }

        /// <summary>
        /// GT1-14: Guarantor Date - End
        /// </summary>
        Value<DateTimeOffset> GuarantorDateEnd { get; }

        /// <summary>
        /// GT1-15: Guarantor Priority
        /// </summary>
        Value<decimal> GuarantorPriority { get; }

        /// <summary>
        /// GT1-16: Guarantor Employer Name
        /// </summary>
        ValueList<XPN> GuarantorEmployerName { get; }

        /// <summary>
        /// GT1-17: Guarantor Employer Address
        /// </summary>
        ValueList<XAD> GuarantorEmployerAddress { get; }

        /// <summary>
        /// GT1-18: Guarantor Employer Phone Number
        /// </summary>
        ValueList<XTN> GuarantorEmployerPhoneNumber { get; }

        /// <summary>
        /// GT1-19: Guarantor Employee ID Number
        /// </summary>
        ValueList<CX> GuarantorEmployeeIdNumber { get; }

        /// <summary>
        /// GT1-20: Guarantor Employment Status
        /// </summary>
        Value<string> GuarantorEmploymentStatus { get; }

        /// <summary>
        /// GT1-21: Guarantor Organization Name
        /// </summary>
        ValueList<XON> GuarantorOrganizationName { get; }

        /// <summary>
        /// GT1-22: Guarantor Billing Hold Flag
        /// </summary>
        Value<string> GuarantorBillingHoldFlag { get; }

        /// <summary>
        /// GT1-23: Guarantor Credit Rating Code
        /// </summary>
        Value<CWE> GuarantorCreditRatingCode { get; }

        /// <summary>
        /// GT1-24: Guarantor Death Date And Time
        /// </summary>
        Value<DateTimeOffset> GuarantorDeathDateAndTime { get; }

        /// <summary>
        /// GT1-25: Guarantor Death Flag
        /// </summary>
        Value<string> GuarantorDeathFlag { get; }

        /// <summary>
        /// GT1-26: Guarantor Charge Adjustment Code
        /// </summary>
        Value<CWE> GuarantorChargeAdjustmentCode { get; }

        /// <summary>
        /// GT1-27: Guarantor Household Annual Income
        /// </summary>
        Value<CP> GuarantorHouseholdAnnualIncome { get; }

        /// <summary>
        /// GT1-28: Guarantor Household Size
        /// </summary>
        Value<decimal> GuarantorHouseholdSize { get; }

        /// <summary>
        /// GT1-29: Guarantor Employer ID Number
        /// </summary>
        ValueList<CX> GuarantorEmployerIdNumber { get; }

        /// <summary>
        /// GT1-30: Guarantor Marital Status Code
        /// </summary>
        Value<CWE> GuarantorMaritalStatusCode { get; }

        /// <summary>
        /// GT1-31: Guarantor Hire Effective Date
        /// </summary>
        Value<DateTimeOffset> GuarantorHireEffectiveDate { get; }

        /// <summary>
        /// GT1-32: Employment Stop Date
        /// </summary>
        Value<DateTimeOffset> EmploymentStopDate { get; }

        /// <summary>
        /// GT1-33: Living Dependency
        /// </summary>
        Value<string> LivingDependency { get; }

        /// <summary>
        /// GT1-34: Ambulatory Status
        /// </summary>
        ValueList<string> AmbulatoryStatus { get; }

        /// <summary>
        /// GT1-35: Citizenship
        /// </summary>
        ValueList<CWE> Citizenship { get; }

        /// <summary>
        /// GT1-36: Primary Language
        /// </summary>
        Value<CWE> PrimaryLanguage { get; }

        /// <summary>
        /// GT1-37: Living Arrangement
        /// </summary>
        Value<string> LivingArrangement { get; }

        /// <summary>
        /// GT1-38: Publicity Code
        /// </summary>
        Value<CWE> PublicityCode { get; }

        /// <summary>
        /// GT1-39: Protection Indicator
        /// </summary>
        Value<string> ProtectionIndicator { get; }

        /// <summary>
        /// GT1-40: Student Indicator
        /// </summary>
        Value<string> StudentIndicator { get; }

        /// <summary>
        /// GT1-41: Religion
        /// </summary>
        Value<CWE> Religion { get; }

        /// <summary>
        /// GT1-42: Mother's Maiden Name
        /// </summary>
        ValueList<XPN> MotherMaidenName { get; }

        /// <summary>
        /// GT1-43: Nationality
        /// </summary>
        Value<CWE> Nationality { get; }

        /// <summary>
        /// GT1-44: Ethnic Group
        /// </summary>
        ValueList<CWE> EthnicGroup { get; }

        /// <summary>
        /// GT1-45: Contact Person's Name
        /// </summary>
        ValueList<XPN> ContactPersonSName { get; }

        /// <summary>
        /// GT1-46: Contact Person's Telephone Number
        /// </summary>
        ValueList<XTN> ContactPersonTelephoneNumber { get; }

        /// <summary>
        /// GT1-47: Contact Reason
        /// </summary>
        Value<CWE> ContactReason { get; }

        /// <summary>
        /// GT1-48: Contact Relationship
        /// </summary>
        Value<string> ContactRelationship { get; }

        /// <summary>
        /// GT1-49: Job Title
        /// </summary>
        Value<string> JobTitle { get; }

        /// <summary>
        /// GT1-50: Job Code/Class
        /// </summary>
        Value<JCC> JobCodeClass { get; }

        /// <summary>
        /// GT1-51: Guarantor Employer's Organization Name
        /// </summary>
        ValueList<XON> GuarantorEmployerOrganizationName { get; }

        /// <summary>
        /// GT1-52: Handicap
        /// </summary>
        Value<string> Handicap { get; }

        /// <summary>
        /// GT1-53: Job Status
        /// </summary>
        Value<string> JobStatus { get; }

        /// <summary>
        /// GT1-54: Guarantor Financial Class
        /// </summary>
        Value<FC> GuarantorFinancialClass { get; }

        /// <summary>
        /// GT1-55: Guarantor Race
        /// </summary>
        ValueList<CWE> GuarantorRace { get; }

        /// <summary>
        /// GT1-56: Guarantor Birth Place
        /// </summary>
        Value<string> GuarantorBirthPlace { get; }

        /// <summary>
        /// GT1-57: VIP Indicator
        /// </summary>
        Value<string> VIPIndicator { get; }
    }
}