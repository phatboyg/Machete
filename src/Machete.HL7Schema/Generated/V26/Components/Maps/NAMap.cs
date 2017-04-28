// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NA (ComponentMap) - Numeric Array
    /// </summary>
    public class NAMap :
        HL7ComponentMap<NA>
    {
        public NAMap()
        {
            Value(x => x.Value1, 1);
            Value(x => x.Value2, 2);
            Value(x => x.Value3, 3);
            Value(x => x.Value4, 4);
        }
    }
}