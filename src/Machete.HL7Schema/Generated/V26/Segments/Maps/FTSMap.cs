// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// FTS (SegmentMap) - File Trailer
    /// </summary>
    public class FTSMap :
        HL7V26SegmentMap<FTS>
    {
        public FTSMap()
        {
            Id = "FTS";

            Name = "File Trailer";

            Value(x => x.FileBatchCount, 1);
            Value(x => x.FileTrailerComment, 2);
        }
    }
}