// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ELD (ComponentMap) - Error Location and Description
    /// </summary>
    public class ELDMap :
        HL7ComponentMap<ELD>
    {
        public ELDMap()
        {
            Value(x => x.SegmentId, 0);
            Value(x => x.SegmentSequence, 1);
            Value(x => x.FieldPosition, 2);
            Entity(x => x.CodeIdentifyingError, 3);
        }
    }
}