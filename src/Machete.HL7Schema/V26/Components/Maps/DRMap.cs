// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DR (ComponentMap) - Date/Time Range
    /// </summary>
    public class DRMap :
        HL7V26ComponentMap<DR>
    {
        public DRMap()
        {
            Value(x => x.RangeStartDateTime, 0, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.RangeEndDateTime, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}