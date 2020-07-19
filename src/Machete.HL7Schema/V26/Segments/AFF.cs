// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// AFF (Segment) - Professional Affiliation
    /// </summary>
    public interface AFF :
        HL7V26Segment
    {
        /// <summary>
        /// AFF-1: Set ID - AFF
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// AFF-2: Professional Organization
        /// </summary>
        Value<XON> ProfessionalOrganization { get; }

        /// <summary>
        /// AFF-3: Professional Organization Address
        /// </summary>
        Value<XAD> ProfessionalOrganizationAddress { get; }

        /// <summary>
        /// AFF-4: Professional Organization Affiliation Date Range
        /// </summary>
        ValueList<DR> ProfessionalOrganizationAffiliationDateRange { get; }

        /// <summary>
        /// AFF-5: Professional Affiliation Additional Information
        /// </summary>
        Value<string> ProfessionalAffiliationAdditionalInformation { get; }
    }
}