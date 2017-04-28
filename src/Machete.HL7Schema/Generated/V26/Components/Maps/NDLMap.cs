// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NDL (ComponentMap) - Name with Date and Location
    /// </summary>
    public class NDLMap :
        HL7ComponentMap<NDL>
    {
        public NDLMap()
        {
            Entity(x => x.Name, 1);
            Value(x => x.StartDateTime, 2, x => {x.Format = "LONGDATETIME2";});
            Value(x => x.EndDateTime, 3, x => {x.Format = "LONGDATETIME3";});
            Value(x => x.PointOfCare, 4);
            Value(x => x.Room, 5);
            Value(x => x.Bed, 6);
            Entity(x => x.Facility, 7);
            Value(x => x.LocationStatus, 8);
            Value(x => x.PatientLocationType, 9);
            Value(x => x.Building, 10);
            Value(x => x.Floor, 11);
        }
    }
}