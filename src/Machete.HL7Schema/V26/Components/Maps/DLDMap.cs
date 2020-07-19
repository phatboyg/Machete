// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DLD (ComponentMap) - Discharge to Location and Date
    /// </summary>
    public class DLDMap :
        HL7V26ComponentMap<DLD>
    {
        public DLDMap()
        {
            Entity(x => x.DischargeToLocation, 0);
            Value(x => x.EffectiveDate, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}