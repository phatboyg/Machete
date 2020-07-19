// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// AUT (Segment) - Authorization Information
    /// </summary>
    public interface AUT :
        HL7V26Segment
    {
        /// <summary>
        /// AUT-1: Authorizing Payor, Plan ID
        /// </summary>
        Value<CWE> AuthorizingPayorPlanId { get; }

        /// <summary>
        /// AUT-2: Authorizing Payor, Company ID
        /// </summary>
        Value<CWE> AuthorizingPayorCompanyId { get; }

        /// <summary>
        /// AUT-3: Authorizing Payor, Company Name
        /// </summary>
        Value<string> AuthorizingPayorCompanyName { get; }

        /// <summary>
        /// AUT-4: Authorization Effective Date
        /// </summary>
        Value<DateTimeOffset> AuthorizationEffectiveDate { get; }

        /// <summary>
        /// AUT-5: Authorization Expiration Date
        /// </summary>
        Value<DateTimeOffset> AuthorizationExpirationDate { get; }

        /// <summary>
        /// AUT-6: Authorization Identifier
        /// </summary>
        Value<EI> AuthorizationIdentifier { get; }

        /// <summary>
        /// AUT-7: Reimbursement Limit
        /// </summary>
        Value<CP> ReimbursementLimit { get; }

        /// <summary>
        /// AUT-8: Requested Number of Treatments
        /// </summary>
        Value<decimal> RequestedNumberOfTreatments { get; }

        /// <summary>
        /// AUT-9: Authorized Number of Treatments
        /// </summary>
        Value<decimal> AuthorizedNumberOfTreatments { get; }

        /// <summary>
        /// AUT-10: Process Date
        /// </summary>
        Value<DateTimeOffset> ProcessDate { get; }
    }
}