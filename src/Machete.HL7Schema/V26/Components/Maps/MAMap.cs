// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MA (ComponentMap) - Multiplexed Array
    /// </summary>
    public class MAMap :
        HL7V26ComponentMap<MA>
    {
        public MAMap()
        {
            Value(x => x.SampleYFromChannel1, 0);
            Value(x => x.SampleYFromChannel2, 1);
            Value(x => x.SampleYFromChannel3, 2);
            Value(x => x.SampleYFromChannel4, 3);
        }
    }
}