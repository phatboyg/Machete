// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QIP (ComponentMap) - Query Input Parameter List
    /// </summary>
    public class QIPMap :
        HL7ComponentMap<QIP>
    {
        public QIPMap()
        {
            Value(x => x.SegmentFieldName, 1);
            Value(x => x.Values, 2);
        }
    }
}