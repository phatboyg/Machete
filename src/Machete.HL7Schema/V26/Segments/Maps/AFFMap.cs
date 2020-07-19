// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// AFF (SegmentMap) - Professional Affiliation
    /// </summary>
    public class AFFMap :
        HL7V26SegmentMap<AFF>
    {
        public AFFMap()
        {
            Id = "AFF";

            Name = "Professional Affiliation";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.ProfessionalOrganization, 2, x => x.IsRequired());
            Entity(x => x.ProfessionalOrganizationAddress, 3);
            Entity(x => x.ProfessionalOrganizationAffiliationDateRange, 4);
            Value(x => x.ProfessionalAffiliationAdditionalInformation, 5);
        }
    }
}