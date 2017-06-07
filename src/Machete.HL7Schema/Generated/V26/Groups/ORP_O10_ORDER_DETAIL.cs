// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORP_O10_ORDER_DETAIL (Group) - 
    /// </summary>
    public interface ORP_O10_ORDER_DETAIL :
        HL7V26Layout
    {
        /// <summary>
        /// RXO
        /// </summary>
        Segment<RXO> RXO { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }

        /// <summary>
        /// COMPONENT
        /// </summary>
        LayoutList<ORP_O10_COMPONENT> Component { get; }
    }
}