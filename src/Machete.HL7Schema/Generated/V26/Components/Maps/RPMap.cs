// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RP (ComponentMap) - Reference Pointer
    /// </summary>
    public class RPMap :
        HL7V26ComponentMap<RP>
    {
        public RPMap()
        {
            Value(x => x.Pointer, 0);
            Entity(x => x.ApplicationId, 1);
            Value(x => x.TypeOfData, 2);
            Value(x => x.Subtype, 3);
        }
    }
}