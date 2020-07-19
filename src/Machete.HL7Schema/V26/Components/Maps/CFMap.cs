// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CF (ComponentMap) - Coded Element with Formatted Values
    /// </summary>
    public class CFMap :
        HL7V26ComponentMap<CF>
    {
        public CFMap()
        {
            Value(x => x.Identifier, 0);
            Value(x => x.FormattedText, 1);
            Value(x => x.NameOfCodingSystem, 2);
            Value(x => x.AlternateIdentifier, 3);
            Value(x => x.AlternateFormattedText, 4);
            Value(x => x.NameOfAlternateCodingSystem, 5);
        }
    }
}