// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LOC (SegmentMap) - Location Identification
    /// </summary>
    public class LOCMap :
        HL7V26SegmentMap<LOC>
    {
        public LOCMap()
        {
            Id = "LOC";

            Name = "Location Identification";

            Entity(x => x.PrimaryKeyValue, 1, x => x.IsRequired());
            Value(x => x.LocationDescription, 2);
            Value(x => x.LocationType, 3, x => x.IsRequired());
            Entity(x => x.OrganizationName, 4);
            Entity(x => x.LocationAddress, 5);
            Entity(x => x.LocationPhone, 6);
            Entity(x => x.LicenseNumber, 7);
            Value(x => x.LocationEquipment, 8);
            Value(x => x.LocationServiceCode, 9);
        }
    }
}