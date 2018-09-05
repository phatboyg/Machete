// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ADD (Segment) - Addendum
    /// </summary>
    public interface ADD :
        HL7V26Segment
    {
        /// <summary>
        /// ADD-1: Addendum Continuation Pointer
        /// </summary>
        Value<string> AddendumContinuationPointer { get; }
    }
}