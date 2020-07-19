// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADD (SegmentMap) - Addendum
    /// </summary>
    public class ADDMap :
        HL7V26SegmentMap<ADD>
    {
        public ADDMap()
        {
            Id = "ADD";

            Name = "Addendum";

            Value(x => x.AddendumContinuationPointer, 1);
        }
    }
}