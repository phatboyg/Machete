// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PL (ComponentMap) - Person Location
    /// </summary>
    public class PLMap :
        HL7ComponentMap<PL>
    {
        public PLMap()
        {
            Value(x => x.PointOfCare, 1);
            Value(x => x.Room, 2);
            Value(x => x.Bed, 3);
            Entity(x => x.Facility, 4);
            Value(x => x.LocationStatus, 5);
            Value(x => x.PersonLocationType, 6);
            Value(x => x.Building, 7);
            Value(x => x.Floor, 8);
            Value(x => x.LocationDescription, 9);
            Entity(x => x.ComprehensiveLocationIdentifier, 10);
            Entity(x => x.AssigningAuthorityForLocation, 11);
        }
    }
}