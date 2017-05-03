// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CE (ComponentMap) - Coded Element
    /// </summary>
    public class CEMap :
        HL7ComponentMap<CE>
    {
        public CEMap()
        {
            Value(x => x.Identifier, 0, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.Text, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.NameOfCodingSystem, 2, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.AlternateIdentifier, 3, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.AlternateText, 4, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.NameOfAlternateCodingSystem, 5, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}