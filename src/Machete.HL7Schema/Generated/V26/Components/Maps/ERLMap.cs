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
        HL7ComponentMap<ERL>
    {
        public ERLMap()
        {
            Value(x => x.SegmentId, 1);
            Value(x => x.SegmentSequence, 2);
            Value(x => x.FieldPosition, 3);
            Value(x => x.FieldRepetition, 4);
            Value(x => x.ComponentNumber, 5);
            Value(x => x.SubComponentNumber, 6);
        }
    }
}