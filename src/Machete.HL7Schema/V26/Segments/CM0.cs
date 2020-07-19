// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// CM0 (Segment) - Clinical Study Master
    /// </summary>
    public interface CM0 :
        HL7V26Segment
    {
        /// <summary>
        /// CM0-1: Set ID - CM0
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// CM0-2: Sponsor Study ID
        /// </summary>
        Value<EI> SponsorStudyId { get; }

        /// <summary>
        /// CM0-3: Alternate Study ID
        /// </summary>
        Value<EI> AlternateStudyId { get; }

        /// <summary>
        /// CM0-4: Title of Study
        /// </summary>
        Value<string> TitleOfStudy { get; }

        /// <summary>
        /// CM0-5: Chairman of Study
        /// </summary>
        ValueList<XCN> ChairmanOfStudy { get; }

        /// <summary>
        /// CM0-6: Last IRB Approval Date
        /// </summary>
        Value<DateTimeOffset> LastIRBApprovalDate { get; }

        /// <summary>
        /// CM0-7: Total Accrual to Date
        /// </summary>
        Value<decimal> TotalAccrualToDate { get; }

        /// <summary>
        /// CM0-8: Last Accrual Date
        /// </summary>
        Value<DateTimeOffset> LastAccrualDate { get; }

        /// <summary>
        /// CM0-9: Contact for Study
        /// </summary>
        ValueList<XCN> ContactForStudy { get; }

        /// <summary>
        /// CM0-10: Contact's Telephone Number
        /// </summary>
        Value<XTN> ContactSTelephoneNumber { get; }

        /// <summary>
        /// CM0-11: Contact's Address
        /// </summary>
        ValueList<XAD> ContactSAddress { get; }
    }
}