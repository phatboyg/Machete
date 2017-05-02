// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RI (ComponentMap) - Repeat Interval
    /// </summary>
    public class RIMap :
        HL7ComponentMap<RI>
    {
        public RIMap()
        {
            Value(x => x.RepeatPattern, 0);
            Value(x => x.ExplicitTimeInterval, 1);
        }
    }
}