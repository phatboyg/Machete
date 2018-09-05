// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PRA (Segment) - Practitioner Detail
    /// </summary>
    public interface PRA :
        HL7V26Segment
    {
        /// <summary>
        /// PRA-1: Primary Key Value - PRA
        /// </summary>
        Value<CWE> PrimaryKeyValue { get; }

        /// <summary>
        /// PRA-2: Practitioner Group
        /// </summary>
        ValueList<CWE> PractitionerGroup { get; }

        /// <summary>
        /// PRA-3: Practitioner Category
        /// </summary>
        ValueList<string> PractitionerCategory { get; }

        /// <summary>
        /// PRA-4: Provider Billing
        /// </summary>
        Value<string> ProviderBilling { get; }

        /// <summary>
        /// PRA-5: Specialty
        /// </summary>
        ValueList<SPD> Specialty { get; }

        /// <summary>
        /// PRA-6: Practitioner ID Numbers
        /// </summary>
        ValueList<PLN> PractitionerIdNumbers { get; }

        /// <summary>
        /// PRA-7: Privileges
        /// </summary>
        ValueList<PIP> Privileges { get; }

        /// <summary>
        /// PRA-8: Date Entered Practice
        /// </summary>
        Value<DateTimeOffset> DateEnteredPractice { get; }

        /// <summary>
        /// PRA-9: Institution
        /// </summary>
        Value<CWE> Institution { get; }

        /// <summary>
        /// PRA-10: Date Left Practice
        /// </summary>
        Value<DateTimeOffset> DateLeftPractice { get; }

        /// <summary>
        /// PRA-11: Government Reimbursement Billing Eligibility
        /// </summary>
        ValueList<CWE> GovernmentReimbursementBillingEligibility { get; }

        /// <summary>
        /// PRA-12: Set ID - PRA
        /// </summary>
        Value<int> SetId { get; }
    }
}