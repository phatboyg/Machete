// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// IAM (Segment) - Patient Adverse Reaction Information
    /// </summary>
    public interface IAM :
        HL7V26Segment
    {
        /// <summary>
        /// IAM-1: Set ID - IAM
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// IAM-2: Allergen Type Code
        /// </summary>
        Value<CWE> AllergenTypeCode { get; }

        /// <summary>
        /// IAM-3: Allergen Code/Mnemonic/Description
        /// </summary>
        Value<CWE> AllergenCodeMnemonicDescription { get; }

        /// <summary>
        /// IAM-4: Allergy Severity Code
        /// </summary>
        Value<CWE> AllergySeverityCode { get; }

        /// <summary>
        /// IAM-5: Allergy Reaction Code
        /// </summary>
        ValueList<string> AllergyReactionCode { get; }

        /// <summary>
        /// IAM-6: Allergy Action Code
        /// </summary>
        Value<CNE> AllergyActionCode { get; }

        /// <summary>
        /// IAM-7: Allergy Unique Identifier
        /// </summary>
        Value<EI> AllergyUniqueIdentifier { get; }

        /// <summary>
        /// IAM-8: Action Reason
        /// </summary>
        Value<string> ActionReason { get; }

        /// <summary>
        /// IAM-9: Sensitivity to Causative Agent Code
        /// </summary>
        Value<CWE> SensitivityToCausativeAgentCode { get; }

        /// <summary>
        /// IAM-10: Allergen Group Code/Mnemonic/Description
        /// </summary>
        Value<CWE> AllergenGroupCodeMnemonicDescription { get; }

        /// <summary>
        /// IAM-11: Onset Date
        /// </summary>
        Value<DateTimeOffset> OnsetDate { get; }

        /// <summary>
        /// IAM-12: Onset Date Text
        /// </summary>
        Value<string> OnsetDateText { get; }

        /// <summary>
        /// IAM-13: Reported Date/Time
        /// </summary>
        Value<DateTimeOffset> ReportedDateTime { get; }

        /// <summary>
        /// IAM-14: Reported By
        /// </summary>
        Value<XPN> ReportedBy { get; }

        /// <summary>
        /// IAM-15: Relationship to Patient Code
        /// </summary>
        Value<CWE> RelationshipToPatientCode { get; }

        /// <summary>
        /// IAM-16: Alert Device Code
        /// </summary>
        Value<CWE> AlertDeviceCode { get; }

        /// <summary>
        /// IAM-17: Allergy Clinical Status Code
        /// </summary>
        Value<CWE> AllergyClinicalStatusCode { get; }

        /// <summary>
        /// IAM-18: Statused by Person
        /// </summary>
        Value<XCN> StatusedByPerson { get; }

        /// <summary>
        /// IAM-19: Statused by Organization
        /// </summary>
        Value<XON> StatusedByOrganization { get; }

        /// <summary>
        /// IAM-20: Statused at Date/Time
        /// </summary>
        Value<DateTimeOffset> StatusedAtDateTime { get; }
    }
}