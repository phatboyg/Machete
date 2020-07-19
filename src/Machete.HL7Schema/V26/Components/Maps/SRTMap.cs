// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRT (ComponentMap) - Sort Order
    /// </summary>
    public class SRTMap :
        HL7V26ComponentMap<SRT>
    {
        public SRTMap()
        {
            Value(x => x.SortByField, 0);
            Value(x => x.Sequencing, 1);
        }
    }
}