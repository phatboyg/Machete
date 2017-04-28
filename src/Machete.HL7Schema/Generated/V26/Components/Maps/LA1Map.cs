// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LA1 (ComponentMap) - Location with Address Variation 1
    /// </summary>
    public class LA1Map :
        HL7ComponentMap<LA1>
    {
        public LA1Map()
        {
            Value(x => x.PointOfCare, 1);
            Value(x => x.Room, 2);
            Value(x => x.Bed, 3);
            Entity(x => x.Facility, 4);
            Value(x => x.LocationStatus, 5);
            Value(x => x.PatientLocationType, 6);
            Value(x => x.Building, 7);
            Value(x => x.Floor, 8);
            Entity(x => x.Address, 9);
        }
    }
}