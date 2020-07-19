// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// NTE (Segment) - Notes and Comments
    /// </summary>
    public interface NTE :
        HL7V26Segment
    {
        /// <summary>
        /// NTE-1: Set ID - NTE
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// NTE-2: Source of Comment
        /// </summary>
        Value<string> SourceOfComment { get; }

        /// <summary>
        /// NTE-3: Comment
        /// </summary>
        ValueList<FT> Comment { get; }

        /// <summary>
        /// NTE-4: Comment Type
        /// </summary>
        Value<CWE> CommentType { get; }

        /// <summary>
        /// NTE-5: Entered By
        /// </summary>
        Value<XCN> EnteredBy { get; }

        /// <summary>
        /// NTE-6: Entered Date/Time
        /// </summary>
        Value<DateTimeOffset> EnteredDateTime { get; }

        /// <summary>
        /// NTE-7: Effective Start Date
        /// </summary>
        Value<DateTimeOffset> EffectiveStartDate { get; }

        /// <summary>
        /// NTE-8: Expiration Date
        /// </summary>
        Value<DateTimeOffset> ExpirationDate { get; }
    }
}