// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RGS (Segment) - Resource Group
    /// </summary>
    public interface RGS :
        HL7V26Segment
    {
        /// <summary>
        /// RGS-1: Set ID - RGS
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// RGS-2: Segment Action Code
        /// </summary>
        Value<string> SegmentActionCode { get; }

        /// <summary>
        /// RGS-3: Resource Group ID
        /// </summary>
        Value<CWE> ResourceGroupId { get; }
    }
}