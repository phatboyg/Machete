// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRD (SegmentMap) - Provider Data
    /// </summary>
    public class PRDMap :
        HL7V26SegmentMap<PRD>
    {
        public PRDMap()
        {
            Id = "PRD";

            Name = "Provider Data";

            Entity(x => x.ProviderRole, 1, x => x.IsRequired());
            Entity(x => x.ProviderName, 2);
            Entity(x => x.ProviderAddress, 3);
            Entity(x => x.ProviderLocation, 4);
            Entity(x => x.ProviderCommunicationInformation, 5);
            Entity(x => x.PreferredMethodOfContact, 6);
            Entity(x => x.ProviderIdentifiers, 7);
            Value(x => x.EffectiveStartDateOfProviderRole, 8, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EffectiveEndDateOfProviderRole, 9, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ProviderOrganizationNameAndIdentifier, 10);
            Entity(x => x.ProviderOrganizationAddress, 11);
            Entity(x => x.ProviderOrganizationLocationInformation, 12);
            Entity(x => x.ProviderOrganizationCommunicationInformation, 13);
            Entity(x => x.ProviderOrganizationMethodOfContact, 14);
        }
    }
}