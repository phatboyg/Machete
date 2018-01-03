namespace Machete.HL7.Tests.TestSchema
{
    public class PLComponentMap :
        HL7ComponentMap<PLComponent, HL7Component>
    {
        public PLComponentMap()
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