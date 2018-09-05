// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OVR (Segment) - Override Segment
    /// </summary>
    public interface OVR :
        HL7V26Segment
    {
        /// <summary>
        /// OVR-1: Business Rule Override Type
        /// </summary>
        Value<CWE> BusinessRuleOverrideType { get; }

        /// <summary>
        /// OVR-2: Business Rule Override Code
        /// </summary>
        Value<CWE> BusinessRuleOverrideCode { get; }

        /// <summary>
        /// OVR-3: Override Comments
        /// </summary>
        Value<TX> OverrideComments { get; }

        /// <summary>
        /// OVR-4: Override Entered By
        /// </summary>
        Value<XCN> OverrideEnteredBy { get; }

        /// <summary>
        /// OVR-5: Override Authorized By
        /// </summary>
        Value<XCN> OverrideAuthorizedBy { get; }
    }
}