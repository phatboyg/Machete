// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NPU (SegmentMap) - Bed Status Update
    /// </summary>
    public class NPUMap :
        HL7V26SegmentMap<NPU>
    {
        public NPUMap()
        {
            Id = "NPU";

            Name = "Bed Status Update";

            Entity(x => x.BedLocation, 1, x => x.IsRequired());
            Value(x => x.BedStatus, 2);
        }
    }
}