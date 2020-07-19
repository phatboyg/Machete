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
        HL7V26ComponentMap<PL>
    {
        public PLMap()
        {
            Value(x => x.PointOfCare, 0);
            Value(x => x.Room, 1);
            Value(x => x.Bed, 2);
            Entity(x => x.Facility, 3);
            Value(x => x.LocationStatus, 4);
            Value(x => x.PersonLocationType, 5);
            Value(x => x.Building, 6);
            Value(x => x.Floor, 7);
            Value(x => x.LocationDescription, 8);
            Entity(x => x.ComprehensiveLocationIdentifier, 9);
            Entity(x => x.AssigningAuthorityForLocation, 10);
        }
    }
}