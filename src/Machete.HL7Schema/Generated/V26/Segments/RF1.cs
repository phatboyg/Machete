// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// RF1 (Segment) - Referral Information
    /// </summary>
    public interface RF1 :
        HL7V26Segment
    {
        /// <summary>
        /// RF1-1: Referral Status
        /// </summary>
        Value<CWE> ReferralStatus { get; }

        /// <summary>
        /// RF1-2: Referral Priority
        /// </summary>
        Value<CWE> ReferralPriority { get; }

        /// <summary>
        /// RF1-3: Referral Type
        /// </summary>
        Value<CWE> ReferralType { get; }

        /// <summary>
        /// RF1-4: Referral Disposition
        /// </summary>
        ValueList<CWE> ReferralDisposition { get; }

        /// <summary>
        /// RF1-5: Referral Category
        /// </summary>
        Value<CWE> ReferralCategory { get; }

        /// <summary>
        /// RF1-6: Originating Referral Identifier
        /// </summary>
        Value<EI> OriginatingReferralIdentifier { get; }

        /// <summary>
        /// RF1-7: Effective Date
        /// </summary>
        Value<DateTimeOffset> EffectiveDate { get; }

        /// <summary>
        /// RF1-8: Expiration Date
        /// </summary>
        Value<DateTimeOffset> ExpirationDate { get; }

        /// <summary>
        /// RF1-9: Process Date
        /// </summary>
        Value<DateTimeOffset> ProceDate { get; }

        /// <summary>
        /// RF1-10: Referral Reason
        /// </summary>
        ValueList<CWE> ReferralReason { get; }

        /// <summary>
        /// RF1-11: External Referral Identifier
        /// </summary>
        ValueList<EI> ExternalReferralIdentifier { get; }

        /// <summary>
        /// RF1-12: Referral Documentation Completion Status
        /// </summary>
        Value<CWE> ReferralDocumentationCompletionStatus { get; }
    }
}