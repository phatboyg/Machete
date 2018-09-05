// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PID (Segment) - Patient Identification
    /// </summary>
    public interface PID :
        HL7V26Segment
    {
        /// <summary>
        /// PID-1: Set ID - PID
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// PID-2: Patient ID
        /// </summary>
        Value<CX> PatientId { get; }

        /// <summary>
        /// PID-3: Patient Identifier List
        /// </summary>
        ValueList<CX> PatientIdentifierList { get; }

        /// <summary>
        /// PID-4: Alternate Patient ID - PID
        /// </summary>
        ValueList<CX> AlternatePatientId { get; }

        /// <summary>
        /// PID-5: Patient Name
        /// </summary>
        ValueList<XPN> PatientName { get; }

        /// <summary>
        /// PID-6: Mother's Maiden Name
        /// </summary>
        ValueList<XPN> MotherSMaidenName { get; }

        /// <summary>
        /// PID-7: Date/Time of Birth
        /// </summary>
        Value<DateTimeOffset> DateTimeOfBirth { get; }

        /// <summary>
        /// PID-8: Administrative Sex
        /// </summary>
        Value<string> AdministrativeSex { get; }

        /// <summary>
        /// PID-9: Patient Alias
        /// </summary>
        ValueList<XPN> PatientAlias { get; }

        /// <summary>
        /// PID-10: Race
        /// </summary>
        ValueList<CWE> Race { get; }

        /// <summary>
        /// PID-11: Patient Address
        /// </summary>
        ValueList<XAD> PatientAddress { get; }

        /// <summary>
        /// PID-12: County Code
        /// </summary>
        Value<string> CountyCode { get; }

        /// <summary>
        /// PID-13: Phone Number - Home
        /// </summary>
        ValueList<XTN> PhoneNumberHome { get; }

        /// <summary>
        /// PID-14: Phone Number - Business
        /// </summary>
        ValueList<XTN> PhoneNumberBusiness { get; }

        /// <summary>
        /// PID-15: Primary Language
        /// </summary>
        Value<CWE> PrimaryLanguage { get; }

        /// <summary>
        /// PID-16: Marital Status
        /// </summary>
        Value<CWE> MaritalStatus { get; }

        /// <summary>
        /// PID-17: Religion
        /// </summary>
        Value<CWE> Religion { get; }

        /// <summary>
        /// PID-18: Patient Account Number
        /// </summary>
        Value<CX> PatientAccountNumber { get; }

        /// <summary>
        /// PID-19: SSN Number - Patient
        /// </summary>
        Value<string> SSNNumberPatient { get; }

        /// <summary>
        /// PID-20: Driver's License Number - Patient
        /// </summary>
        Value<DLN> DriverSLicenseNumberPatient { get; }

        /// <summary>
        /// PID-21: Mother's Identifier
        /// </summary>
        ValueList<CX> MotherSIdentifier { get; }

        /// <summary>
        /// PID-22: Ethnic Group
        /// </summary>
        ValueList<CWE> EthnicGroup { get; }

        /// <summary>
        /// PID-23: Birth Place
        /// </summary>
        Value<string> BirthPlace { get; }

        /// <summary>
        /// PID-24: Multiple Birth Indicator
        /// </summary>
        Value<string> MultipleBirthIndicator { get; }

        /// <summary>
        /// PID-25: Birth Order
        /// </summary>
        Value<decimal> BirthOrder { get; }

        /// <summary>
        /// PID-26: Citizenship
        /// </summary>
        ValueList<CWE> Citizenship { get; }

        /// <summary>
        /// PID-27: Veterans Military Status
        /// </summary>
        Value<CWE> VeteranMilitaryStatus { get; }

        /// <summary>
        /// PID-28: Nationality
        /// </summary>
        Value<CWE> Nationality { get; }

        /// <summary>
        /// PID-29: Patient Death Date and Time
        /// </summary>
        Value<DateTimeOffset> PatientDeathDateAndTime { get; }

        /// <summary>
        /// PID-30: Patient Death Indicator
        /// </summary>
        Value<string> PatientDeathIndicator { get; }

        /// <summary>
        /// PID-31: Identity Unknown Indicator
        /// </summary>
        Value<string> IdentityUnknownIndicator { get; }

        /// <summary>
        /// PID-32: Identity Reliability Code
        /// </summary>
        ValueList<string> IdentityReliabilityCode { get; }

        /// <summary>
        /// PID-33: Last Update Date/Time
        /// </summary>
        Value<DateTimeOffset> LastUpdateDateTime { get; }

        /// <summary>
        /// PID-34: Last Update Facility
        /// </summary>
        Value<HD> LastUpdateFacility { get; }

        /// <summary>
        /// PID-35: Species Code
        /// </summary>
        Value<CWE> SpecieCode { get; }

        /// <summary>
        /// PID-36: Breed Code
        /// </summary>
        Value<CWE> BreedCode { get; }

        /// <summary>
        /// PID-37: Strain
        /// </summary>
        Value<string> Strain { get; }

        /// <summary>
        /// PID-38: Production Class Code
        /// </summary>
        Value<CWE> ProductionClassCode { get; }

        /// <summary>
        /// PID-39: Tribal Citizenship
        /// </summary>
        ValueList<CWE> TribalCitizenship { get; }
    }
}