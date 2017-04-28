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
        HL7ComponentMap<MA>
    {
        public MAMap()
        {
            Value(x => x.SampleYFromChannel1, 1);
            Value(x => x.SampleYFromChannel2, 2);
            Value(x => x.SampleYFromChannel3, 3);
            Value(x => x.SampleYFromChannel4, 4);
        }
    }
}