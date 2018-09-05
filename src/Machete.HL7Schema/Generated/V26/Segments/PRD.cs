// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PRD (Segment) - Provider Data
    /// </summary>
    public interface PRD :
        HL7V26Segment
    {
        /// <summary>
        /// PRD-1: Provider Role
        /// </summary>
        ValueList<CWE> ProviderRole { get; }

        /// <summary>
        /// PRD-2: Provider Name
        /// </summary>
        ValueList<XPN> ProviderName { get; }

        /// <summary>
        /// PRD-3: Provider Address
        /// </summary>
        ValueList<XAD> ProviderAddress { get; }

        /// <summary>
        /// PRD-4: Provider Location
        /// </summary>
        Value<PL> ProviderLocation { get; }

        /// <summary>
        /// PRD-5: Provider Communication Information
        /// </summary>
        ValueList<XTN> ProviderCommunicationInformation { get; }

        /// <summary>
        /// PRD-6: Preferred Method of Contact
        /// </summary>
        Value<CWE> PreferredMethodOfContact { get; }

        /// <summary>
        /// PRD-7: Provider Identifiers
        /// </summary>
        ValueList<PLN> ProviderIdentifiers { get; }

        /// <summary>
        /// PRD-8: Effective Start Date of Provider Role
        /// </summary>
        Value<DateTimeOffset> EffectiveStartDateOfProviderRole { get; }

        /// <summary>
        /// PRD-9: Effective End Date of Provider Role
        /// </summary>
        ValueList<DateTimeOffset> EffectiveEndDateOfProviderRole { get; }

        /// <summary>
        /// PRD-10: Provider Organization Name and Identifier
        /// </summary>
        Value<XON> ProviderOrganizationNameAndIdentifier { get; }

        /// <summary>
        /// PRD-11: Provider Organization Address
        /// </summary>
        ValueList<XAD> ProviderOrganizationAddress { get; }

        /// <summary>
        /// PRD-12: Provider Organization Location Information
        /// </summary>
        ValueList<PL> ProviderOrganizationLocationInformation { get; }

        /// <summary>
        /// PRD-13: Provider Organization Communication Information
        /// </summary>
        ValueList<XTN> ProviderOrganizationCommunicationInformation { get; }

        /// <summary>
        /// PRD-14: Provider Organization Method of Contact
        /// </summary>
        Value<CWE> ProviderOrganizationMethodOfContact { get; }
    }
}