// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// STF (Segment) - Staff Identification
    /// </summary>
    public interface STF :
        HL7V26Segment
    {
        /// <summary>
        /// STF-1: Primary Key Value - STF
        /// </summary>
        Value<CWE> PrimaryKeyValue { get; }

        /// <summary>
        /// STF-2: Staff Identifier List
        /// </summary>
        ValueList<CX> StaffIdentifierList { get; }

        /// <summary>
        /// STF-3: Staff Name
        /// </summary>
        ValueList<XPN> StaffName { get; }

        /// <summary>
        /// STF-4: Staff Type
        /// </summary>
        ValueList<string> StaffType { get; }

        /// <summary>
        /// STF-5: Administrative Sex
        /// </summary>
        Value<string> AdministrativeSex { get; }

        /// <summary>
        /// STF-6: Date/Time of Birth
        /// </summary>
        Value<DateTimeOffset> DateTimeOfBirth { get; }

        /// <summary>
        /// STF-7: Active/Inactive Flag
        /// </summary>
        Value<string> ActiveInactiveFlag { get; }

        /// <summary>
        /// STF-8: Department
        /// </summary>
        ValueList<CWE> Department { get; }

        /// <summary>
        /// STF-9: Hospital Service - STF
        /// </summary>
        ValueList<CWE> HospitalService { get; }

        /// <summary>
        /// STF-10: Phone
        /// </summary>
        ValueList<XTN> Phone { get; }

        /// <summary>
        /// STF-11: Office/Home Address/Birthplace
        /// </summary>
        ValueList<XAD> OfficeHomeAddressBirthplace { get; }

        /// <summary>
        /// STF-12: Institution Activation Date
        /// </summary>
        ValueList<DIN> InstitutionActivationDate { get; }

        /// <summary>
        /// STF-13: Institution Inactivation Date
        /// </summary>
        ValueList<DIN> InstitutionInactivationDate { get; }

        /// <summary>
        /// STF-14: Backup Person ID
        /// </summary>
        ValueList<CWE> BackupPersonId { get; }

        /// <summary>
        /// STF-15: E-Mail Address
        /// </summary>
        ValueList<string> EMailAddress { get; }

        /// <summary>
        /// STF-16: Preferred Method of Contact
        /// </summary>
        Value<CWE> PreferredMethodOfContact { get; }

        /// <summary>
        /// STF-17: Marital Status
        /// </summary>
        Value<CWE> MaritalStatus { get; }

        /// <summary>
        /// STF-18: Job Title
        /// </summary>
        Value<string> JobTitle { get; }

        /// <summary>
        /// STF-19: Job Code/Class
        /// </summary>
        Value<JCC> JobCodeClass { get; }

        /// <summary>
        /// STF-20: Employment Status Code
        /// </summary>
        Value<CWE> EmploymentStatusCode { get; }

        /// <summary>
        /// STF-21: Additional Insured on Auto
        /// </summary>
        Value<string> AdditionalInsuredOnAuto { get; }

        /// <summary>
        /// STF-22: Driver's License Number - Staff
        /// </summary>
        Value<DLN> DriverSLicenseNumberStaff { get; }

        /// <summary>
        /// STF-23: Copy Auto Ins
        /// </summary>
        Value<string> CopyAutoIns { get; }

        /// <summary>
        /// STF-24: Auto Ins Expires
        /// </summary>
        Value<DateTimeOffset> AutoInsExpires { get; }

        /// <summary>
        /// STF-25: Date Last DMV Review
        /// </summary>
        Value<DateTimeOffset> DateLastDMVReview { get; }

        /// <summary>
        /// STF-26: Date Next DMV Review
        /// </summary>
        Value<DateTimeOffset> DateNextDMVReview { get; }

        /// <summary>
        /// STF-27: Race
        /// </summary>
        Value<CWE> Race { get; }

        /// <summary>
        /// STF-28: Ethnic Group
        /// </summary>
        Value<CWE> EthnicGroup { get; }

        /// <summary>
        /// STF-29: Re-activation Approval Indicator
        /// </summary>
        Value<string> ReActivationApprovalIndicator { get; }

        /// <summary>
        /// STF-30: Citizenship
        /// </summary>
        ValueList<CWE> Citizenship { get; }

        /// <summary>
        /// STF-31: Date/Time of Death
        /// </summary>
        Value<DateTimeOffset> DateTimeOfDeath { get; }

        /// <summary>
        /// STF-32: Death Indicator
        /// </summary>
        Value<string> DeathIndicator { get; }

        /// <summary>
        /// STF-33: Institution Relationship Type Code
        /// </summary>
        Value<CWE> InstitutionRelationshipTypeCode { get; }

        /// <summary>
        /// STF-34: Institution Relationship Period
        /// </summary>
        Value<DR> InstitutionRelationshipPeriod { get; }

        /// <summary>
        /// STF-35: Expected Return Date
        /// </summary>
        Value<DateTimeOffset> ExpectedReturnDate { get; }

        /// <summary>
        /// STF-36: Cost Center Code
        /// </summary>
        ValueList<CWE> CostCenterCode { get; }

        /// <summary>
        /// STF-37: Generic Classification Indicator
        /// </summary>
        Value<string> GenericClassificationIndicator { get; }

        /// <summary>
        /// STF-38: Inactive Reason Code
        /// </summary>
        Value<CWE> InactiveReasonCode { get; }

        /// <summary>
        /// STF-39: Generic resource type or category
        /// </summary>
        ValueList<CWE> GenericResourceTypeOrCategory { get; }
    }
}