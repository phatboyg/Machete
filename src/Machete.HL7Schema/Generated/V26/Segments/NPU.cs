// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// NPU (Segment) - Bed Status Update
    /// </summary>
    public interface NPU :
        HL7V26Segment
    {
        /// <summary>
        /// NPU-1: Bed Location
        /// </summary>
        Value<PL> BedLocation { get; }

        /// <summary>
        /// NPU-2: Bed Status
        /// </summary>
        Value<string> BedStatus { get; }
    }
}