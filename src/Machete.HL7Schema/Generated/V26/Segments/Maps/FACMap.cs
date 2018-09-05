// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// FAC (SegmentMap) - Facility
    /// </summary>
    public class FACMap :
        HL7V26SegmentMap<FAC>
    {
        public FACMap()
        {
            Id = "FAC";

            Name = "Facility";

            Entity(x => x.FacilityId, 1, x => x.IsRequired());
            Value(x => x.FacilityType, 2);
            Entity(x => x.FacilityAddress, 3, x => x.IsRequired());
            Entity(x => x.FacilityTelecommunication, 4, x => x.IsRequired());
            Entity(x => x.ContactPerson, 5);
            Value(x => x.ContactTitle, 6);
            Entity(x => x.ContactAddress, 7);
            Entity(x => x.ContactTelecommunication, 8);
            Entity(x => x.SignatureAuthority, 9, x => x.IsRequired());
            Value(x => x.SignatureAuthorityTitle, 10);
            Entity(x => x.SignatureAuthorityAddress, 11);
            Entity(x => x.SignatureAuthorityTelecommunication, 12);
        }
    }
}