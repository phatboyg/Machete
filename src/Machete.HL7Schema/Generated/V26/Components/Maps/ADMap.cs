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
        HL7ComponentMap<AD>
    {
        public ADMap()
        {
            Value(x => x.StreetAddress, 1);
            Value(x => x.OtherDesignation, 2);
            Value(x => x.City, 3);
            Value(x => x.StateOrProvince, 4);
            Value(x => x.ZipOrPostalCode, 5);
            Value(x => x.Country, 6);
            Value(x => x.AddressType, 7);
            Value(x => x.OtherGeographicDesignation, 8);
        }
    }
}