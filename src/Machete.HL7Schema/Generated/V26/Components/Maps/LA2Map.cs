// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LA2 (ComponentMap) - Location with Address Variation 2
    /// </summary>
    public class LA2Map :
        HL7V26ComponentMap<LA2>
    {
        public LA2Map()
        {
            Value(x => x.PointOfCare, 0);
            Value(x => x.Room, 1);
            Value(x => x.Bed, 2);
            Entity(x => x.Facility, 3);
            Value(x => x.LocationStatus, 4);
            Value(x => x.PatientLocationType, 5);
            Value(x => x.Building, 6);
            Value(x => x.Floor, 7);
            Value(x => x.StreetAddress, 8);
            Value(x => x.OtherDesignation, 9);
            Value(x => x.City, 10);
            Value(x => x.StateOrProvince, 11);
            Value(x => x.ZipOrPostalCode, 12);
            Value(x => x.Country, 13);
            Value(x => x.AddressType, 14);
            Value(x => x.OtherGeographicDesignation, 15);
        }
    }
}