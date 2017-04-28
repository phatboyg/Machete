// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BTS (SegmentMap) - Batch Trailer
    /// </summary>
    public class BTSMap :
        HL7SegmentMap<BTS>
    {
        public BTSMap()
        {
            Id = "BTS";

            Name = "Batch Trailer";

            Value(x => x.BatchMessageCount, 1);
            Value(x => x.BatchComment, 2);
            Value(x => x.BatchTotals, 3);
        }
    }
}