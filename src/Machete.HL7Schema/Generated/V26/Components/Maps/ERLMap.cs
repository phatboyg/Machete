// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ERL (ComponentMap) - Error Location
    /// </summary>
    public class ERLMap :
        HL7V26ComponentMap<ERL>
    {
        public ERLMap()
        {
            Value(x => x.SegmentId, 0);
            Value(x => x.SegmentSequence, 1);
            Value(x => x.FieldPosition, 2);
            Value(x => x.FieldRepetition, 3);
            Value(x => x.ComponentNumber, 4);
            Value(x => x.SubComponentNumber, 5);
        }
    }
}