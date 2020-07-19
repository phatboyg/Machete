// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// NK1 (Segment) - Next of Kin / Associated Parties
    /// </summary>
    public interface NK1 :
        HL7V26Segment
    {
        /// <summary>
        /// NK1-1: Set ID - NK1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// NK1-2: Name
        /// </summary>
        ValueList<XPN> Name { get; }

        /// <summary>
        /// NK1-3: Relationship
        /// </summary>
        Value<CWE> Relationship { get; }

        /// <summary>
        /// NK1-4: Address
        /// </summary>
        ValueList<XAD> Address { get; }

        /// <summary>
        /// NK1-5: Phone Number
        /// </summary>
        ValueList<XTN> PhoneNumber { get; }

        /// <summary>
        /// NK1-6: Business Phone Number
        /// </summary>
        ValueList<XTN> BusinessPhoneNumber { get; }

        /// <summary>
        /// NK1-7: Contact Role
        /// </summary>
        Value<CWE> ContactRole { get; }

        /// <summary>
        /// NK1-8: Start Date
        /// </summary>
        Value<DateTimeOffset> StartDate { get; }

        /// <summary>
        /// NK1-9: End Date
        /// </summary>
        Value<DateTimeOffset> EndDate { get; }

        /// <summary>
        /// NK1-10: Next of Kin / Associated Parties Job Title
        /// </summary>
        Value<string> NextOfKinAssociatedPartiesJobTitle { get; }

        /// <summary>
        /// NK1-11: Next of Kin / Associated Parties Job Code/Class
        /// </summary>
        Value<JCC> NextOfKinAssociatedPartiesJobCodeClass { get; }

        /// <summary>
        /// NK1-12: Next of Kin / Associated Parties Employee Number
        /// </summary>
        Value<CX> NextOfKinAssociatedPartiesEmployeeNumber { get; }

        /// <summary>
        /// NK1-13: Organization Name - NK1
        /// </summary>
        ValueList<XON> OrganizationName { get; }

        /// <summary>
        /// NK1-14: Marital Status
        /// </summary>
        Value<CWE> MaritalStatus { get; }

        /// <summary>
        /// NK1-15: Administrative Sex
        /// </summary>
        Value<string> AdministrativeSex { get; }

        /// <summary>
        /// NK1-16: Date/Time of Birth
        /// </summary>
        Value<DateTimeOffset> DateTimeOfBirth { get; }

        /// <summary>
        /// NK1-17: Living Dependency
        /// </summary>
        ValueList<string> LivingDependency { get; }

        /// <summary>
        /// NK1-18: Ambulatory Status
        /// </summary>
        ValueList<string> AmbulatoryStatus { get; }

        /// <summary>
        /// NK1-19: Citizenship
        /// </summary>
        ValueList<CWE> Citizenship { get; }

        /// <summary>
        /// NK1-20: Primary Language
        /// </summary>
        Value<CWE> PrimaryLanguage { get; }

        /// <summary>
        /// NK1-21: Living Arrangement
        /// </summary>
        Value<string> LivingArrangement { get; }

        /// <summary>
        /// NK1-22: Publicity Code
        /// </summary>
        Value<CWE> PublicityCode { get; }

        /// <summary>
        /// NK1-23: Protection Indicator
        /// </summary>
        Value<string> ProtectionIndicator { get; }

        /// <summary>
        /// NK1-24: Student Indicator
        /// </summary>
        Value<string> StudentIndicator { get; }

        /// <summary>
        /// NK1-25: Religion
        /// </summary>
        Value<CWE> Religion { get; }

        /// <summary>
        /// NK1-26: Mother's Maiden Name
        /// </summary>
        ValueList<XPN> MotherSMaidenName { get; }

        /// <summary>
        /// NK1-27: Nationality
        /// </summary>
        Value<CWE> Nationality { get; }

        /// <summary>
        /// NK1-28: Ethnic Group
        /// </summary>
        ValueList<CWE> EthnicGroup { get; }

        /// <summary>
        /// NK1-29: Contact Reason
        /// </summary>
        ValueList<CWE> ContactReason { get; }

        /// <summary>
        /// NK1-30: Contact Person's Name
        /// </summary>
        ValueList<XPN> ContactPersonSName { get; }

        /// <summary>
        /// NK1-31: Contact Person's Telephone Number
        /// </summary>
        ValueList<XTN> ContactPersonSTelephoneNumber { get; }

        /// <summary>
        /// NK1-32: Contact Person's Address
        /// </summary>
        ValueList<XAD> ContactPersonSAddress { get; }

        /// <summary>
        /// NK1-33: Next of Kin/Associated Party's Identifiers
        /// </summary>
        ValueList<CX> NextOfKinAssociatedPartySIdentifiers { get; }

        /// <summary>
        /// NK1-34: Job Status
        /// </summary>
        Value<string> JobStatus { get; }

        /// <summary>
        /// NK1-35: Race
        /// </summary>
        ValueList<CWE> Race { get; }

        /// <summary>
        /// NK1-36: Handicap
        /// </summary>
        Value<string> Handicap { get; }

        /// <summary>
        /// NK1-37: Contact Person Social Security Number
        /// </summary>
        Value<string> ContactPersonSocialSecurityNumber { get; }

        /// <summary>
        /// NK1-38: Next of Kin Birth Place
        /// </summary>
        Value<string> NextOfKinBirthPlace { get; }

        /// <summary>
        /// NK1-39: VIP Indicator
        /// </summary>
        Value<string> VIPIndicator { get; }
    }
}