// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NR (ComponentMap) - Numeric Range
    /// </summary>
    public class NRMap :
        HL7ComponentMap<NR>
    {
        public NRMap()
        {
            Value(x => x.LowValue, 0);
            Value(x => x.HighValue, 1);
        }
    }
}