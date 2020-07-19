// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ORG (Segment) - Practitioner Organization Unit
    /// </summary>
    public interface ORG :
        HL7V26Segment
    {
        /// <summary>
        /// ORG-1: Set ID - ORG
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// ORG-2: Organization Unit Code
        /// </summary>
        Value<CWE> OrganizationUnitCode { get; }

        /// <summary>
        /// ORG-3: Organization Unit Type Code
        /// </summary>
        Value<CWE> OrganizationUnitTypeCode { get; }

        /// <summary>
        /// ORG-4: Primary Org Unit Indicator
        /// </summary>
        Value<string> PrimaryOrgUnitIndicator { get; }

        /// <summary>
        /// ORG-5: Practitioner Org Unit Identifier
        /// </summary>
        Value<CX> PractitionerOrgUnitIdentifier { get; }

        /// <summary>
        /// ORG-6: Health Care Provider Type Code
        /// </summary>
        Value<CWE> HealthCareProviderTypeCode { get; }

        /// <summary>
        /// ORG-7: Health Care Provider Classification Code
        /// </summary>
        Value<CWE> HealthCareProviderClassificationCode { get; }

        /// <summary>
        /// ORG-8: Health Care Provider Area of Specialization Code
        /// </summary>
        Value<CWE> HealthCareProviderAreaOfSpecializationCode { get; }

        /// <summary>
        /// ORG-9: Effective Date Range
        /// </summary>
        Value<DR> EffectiveDateRange { get; }

        /// <summary>
        /// ORG-10: Employment Status Code
        /// </summary>
        Value<CWE> EmploymentStatusCode { get; }

        /// <summary>
        /// ORG-11: Board Approval Indicator
        /// </summary>
        Value<string> BoardApprovalIndicator { get; }

        /// <summary>
        /// ORG-12: Primary Care Physician Indicator
        /// </summary>
        Value<string> PrimaryCarePhysicianIndicator { get; }
    }
}