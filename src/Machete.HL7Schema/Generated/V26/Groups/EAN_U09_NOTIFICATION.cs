// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EAN_U09_NOTIFICATION (Group) - 
    /// </summary>
    public interface EAN_U09_NOTIFICATION :
        HL7Layout
    {
        /// <summary>
        /// NDS
        /// </summary>
        Segment<NDS> NDS { get; }

        /// <summary>
        /// NTE
        /// </summary>
        Segment<NTE> NTE { get; }
    }
}