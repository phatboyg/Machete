// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// AD (ComponentMap) - Address
    /// </summary>
    public class ADMap :
        HL7V26ComponentMap<AD>
    {
        public ADMap()
        {
            Value(x => x.StreetAddress, 0);
            Value(x => x.OtherDesignation, 1);
            Value(x => x.City, 2);
            Value(x => x.StateOrProvince, 3);
            Value(x => x.ZipOrPostalCode, 4);
            Value(x => x.Country, 5);
            Value(x => x.AddressType, 6);
            Value(x => x.OtherGeographicDesignation, 7);
        }
    }
}