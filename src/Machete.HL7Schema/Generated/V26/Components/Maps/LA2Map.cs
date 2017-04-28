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
        HL7ComponentMap<LA2>
    {
        public LA2Map()
        {
            Value(x => x.PointOfCare, 1);
            Value(x => x.Room, 2);
            Value(x => x.Bed, 3);
            Entity(x => x.Facility, 4);
            Value(x => x.LocationStatus, 5);
            Value(x => x.PatientLocationType, 6);
            Value(x => x.Building, 7);
            Value(x => x.Floor, 8);
            Value(x => x.StreetAddress, 9);
            Value(x => x.OtherDesignation, 10);
            Value(x => x.City, 11);
            Value(x => x.StateOrProvince, 12);
            Value(x => x.ZipOrPostalCode, 13);
            Value(x => x.Country, 14);
            Value(x => x.AddressType, 15);
            Value(x => x.OtherGeographicDesignation, 16);
        }
    }
}