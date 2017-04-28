// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CNE (ComponentMap) - Coded with No Exceptions
    /// </summary>
    public class CNEMap :
        HL7ComponentMap<CNE>
    {
        public CNEMap()
        {
            Value(x => x.Identifier, 1);
            Value(x => x.Text, 2);
            Value(x => x.NameOfCodingSystem, 3);
            Value(x => x.AlternateIdentifier, 4);
            Value(x => x.AlternateText, 5);
            Value(x => x.NameOfAlternateCodingSystem, 6);
            Value(x => x.CodingSystemVersionId, 7);
            Value(x => x.AlternateCodingSystemVersionId, 8);
            Value(x => x.OriginalText, 9);
        }
    }
}