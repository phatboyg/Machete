// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SCV (ComponentMap) - Scheduling Class Value Pair
    /// </summary>
    public class SCVMap :
        HL7V26ComponentMap<SCV>
    {
        public SCVMap()
        {
            Entity(x => x.ParameterClass, 0);
            Value(x => x.ParameterValue, 1);
        }
    }
}