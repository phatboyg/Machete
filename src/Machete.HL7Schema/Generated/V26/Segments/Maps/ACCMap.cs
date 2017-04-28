// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ACC (SegmentMap) - Accident
    /// </summary>
    public class ACCMap :
        HL7SegmentMap<ACC>
    {
        public ACCMap()
        {
            Id = "ACC";

            Name = "Accident";

            Value(x => x.AccidentDateTime, 1, x => {x.Format = "LONGDATETIME1";});
            Entity(x => x.AccidentCode, 2);
            Value(x => x.AccidentLocation, 3);
            Entity(x => x.AutoAccidentState, 4);
            Value(x => x.AccidentJobRelatedIndicator, 5);
            Value(x => x.AccidentDeathIndicator, 6);
            Entity(x => x.EnteredBy, 7);
            Value(x => x.AccidentDescription, 8);
            Value(x => x.BroughtInBy, 9);
            Value(x => x.PoliceNotifiedIndicator, 10);
            Entity(x => x.AccidentAddress, 11);
        }
    }
}