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
            Value(x => x.Identifier, 1, x => {x.Format = "LONGDATETIME1";});
            Value(x => x.Text, 2, x => {x.Format = "LONGDATETIME2";});
            Value(x => x.NameOfCodingSystem, 3, x => {x.Format = "LONGDATETIME3";});
            Value(x => x.AlternateIdentifier, 4, x => {x.Format = "LONGDATETIME4";});
            Value(x => x.AlternateText, 5, x => {x.Format = "LONGDATETIME5";});
            Value(x => x.NameOfAlternateCodingSystem, 6, x => {x.Format = "LONGDATETIME6";});
        }
    }
}