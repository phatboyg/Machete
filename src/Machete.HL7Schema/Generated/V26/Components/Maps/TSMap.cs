// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// TS (ComponentMap) - Time Stamp
    /// </summary>
    public class TSMap :
        HL7ComponentMap<TS>
    {
        public TSMap()
        {
            Value(x => x.Time, 0, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DegreeOfPrecision, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}