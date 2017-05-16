// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RAS_O17_COMPONENTS (Group) - 
    /// </summary>
    public interface RAS_O17_COMPONENTS :
        HL7Layout
    {
        /// <summary>
        /// RXC
        /// </summary>
        Segment<RXC> RXC { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}