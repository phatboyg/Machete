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
        HL7V26ComponentMap<NA>
    {
        public NAMap()
        {
            Value(x => x.Value1, 0);
            Value(x => x.Value2, 1);
            Value(x => x.Value3, 2);
            Value(x => x.Value4, 3);
        }
    }
}