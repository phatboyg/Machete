// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RCD (ComponentMap) - Row Column Definition
    /// </summary>
    public class RCDMap :
        HL7V26ComponentMap<RCD>
    {
        public RCDMap()
        {
            Value(x => x.SegmentFieldName, 0);
            Value(x => x.HL7DataType, 1);
            Value(x => x.MaximumColumnWidth, 2);
        }
    }
}