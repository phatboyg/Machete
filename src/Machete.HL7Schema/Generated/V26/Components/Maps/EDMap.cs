// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ED (ComponentMap) - Encapsulated Data
    /// </summary>
    public class EDMap :
        HL7ComponentMap<ED>
    {
        public EDMap()
        {
            Entity(x => x.SourceApplication, 1);
            Value(x => x.TypeOfData, 2);
            Value(x => x.DataSubtype, 3);
            Value(x => x.Encoding, 4);
            Value(x => x.Data, 5);
        }
    }
}