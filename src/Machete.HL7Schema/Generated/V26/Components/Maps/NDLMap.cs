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
            Entity(x => x.Name, 0);
            Value(x => x.StartDateTime, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.EndDateTime, 2, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.PointOfCare, 3);
            Value(x => x.Room, 4);
            Value(x => x.Bed, 5);
            Entity(x => x.Facility, 6);
            Value(x => x.LocationStatus, 7);
            Value(x => x.PatientLocationType, 8);
            Value(x => x.Building, 9);
            Value(x => x.Floor, 10);
        }
    }
}