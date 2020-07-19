// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RAS_O17_ORDER_DETAIL_SUPPLEMENT (Group) - 
    /// </summary>
    public interface RAS_O17_ORDER_DETAIL_SUPPLEMENT :
        HL7V26Layout
    {
        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }

        /// <summary>
        /// COMPONENTS
        /// </summary>
        LayoutList<RAS_O17_COMPONENTS> Components { get; }
    }
}