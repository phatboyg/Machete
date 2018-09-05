// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// FTS (Segment) - File Trailer
    /// </summary>
    public interface FTS :
        HL7V26Segment
    {
        /// <summary>
        /// FTS-1: File Batch Count
        /// </summary>
        Value<decimal> FileBatchCount { get; }

        /// <summary>
        /// FTS-2: File Trailer Comment
        /// </summary>
        Value<string> FileTrailerComment { get; }
    }
}