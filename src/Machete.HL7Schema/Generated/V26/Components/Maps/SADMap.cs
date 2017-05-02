// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SAD (ComponentMap) - Street Address
    /// </summary>
    public class SADMap :
        HL7ComponentMap<SAD>
    {
        public SADMap()
        {
            Value(x => x.StreetOrMailingAddress, 0);
            Value(x => x.StreetName, 1);
            Value(x => x.DwellingNumber, 2);
        }
    }
}