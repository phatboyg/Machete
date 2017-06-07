// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RFR (ComponentMap) - Reference Range
    /// </summary>
    public class RFRMap :
        HL7V26ComponentMap<RFR>
    {
        public RFRMap()
        {
            Entity(x => x.NumericRange, 0);
            Value(x => x.AdministrativeSex, 1);
            Entity(x => x.AgeRange, 2);
            Entity(x => x.GestationalAgeRange, 3);
            Value(x => x.Species, 4);
            Value(x => x.RaceSubspecies, 5);
            Value(x => x.Conditions, 6);
        }
    }
}