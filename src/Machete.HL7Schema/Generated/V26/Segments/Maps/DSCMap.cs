// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DSC (SegmentMap) - Continuation Pointer
    /// </summary>
    public class DSCMap :
        HL7SegmentMap<DSC>
    {
        public DSCMap()
        {
            Id = "DSC";

            Name = "Continuation Pointer";

            Value(x => x.ContinuationPointer, 1);
            Value(x => x.ContinuationStyle, 2);
        }
    }
}