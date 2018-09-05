// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORG (SegmentMap) - Practitioner Organization Unit
    /// </summary>
    public class ORGMap :
        HL7V26SegmentMap<ORG>
    {
        public ORGMap()
        {
            Id = "ORG";

            Name = "Practitioner Organization Unit";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.OrganizationUnitCode, 2);
            Entity(x => x.OrganizationUnitTypeCode, 3);
            Value(x => x.PrimaryOrgUnitIndicator, 4);
            Entity(x => x.PractitionerOrgUnitIdentifier, 5);
            Entity(x => x.HealthCareProviderTypeCode, 6);
            Entity(x => x.HealthCareProviderClassificationCode, 7);
            Entity(x => x.HealthCareProviderAreaOfSpecializationCode, 8);
            Entity(x => x.EffectiveDateRange, 9);
            Entity(x => x.EmploymentStatusCode, 10);
            Value(x => x.BoardApprovalIndicator, 11);
            Value(x => x.PrimaryCarePhysicianIndicator, 12);
        }
    }
}