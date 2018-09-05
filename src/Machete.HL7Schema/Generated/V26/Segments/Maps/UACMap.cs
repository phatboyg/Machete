// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// UAC (SegmentMap) - User Authentication Credential Segment
    /// </summary>
    public class UACMap :
        HL7V26SegmentMap<UAC>
    {
        public UACMap()
        {
            Id = "UAC";

            Name = "User Authentication Credential Segment";

            Entity(x => x.UserAuthenticationCredentialTypeCode, 1, x => x.IsRequired());
            Entity(x => x.UserAuthenticationCredential, 2, x => x.IsRequired());
        }
    }
}