// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CTD (SegmentMap) - Contact Data
    /// </summary>
    public class CTDMap :
        HL7V26SegmentMap<CTD>
    {
        public CTDMap()
        {
            Id = "CTD";

            Name = "Contact Data";

            Entity(x => x.ContactRole, 1, x => x.IsRequired());
            Entity(x => x.ContactName, 2);
            Entity(x => x.ContactAddress, 3);
            Entity(x => x.ContactLocation, 4);
            Entity(x => x.ContactCommunicationInformation, 5);
            Entity(x => x.PreferredMethodOfContact, 6);
            Entity(x => x.ContactIdentifiers, 7);
        }
    }
}