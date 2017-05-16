// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RGV_O15_ORDER_DETAIL_SUPPLEMENT (Group) - 
    /// </summary>
    public interface RGV_O15_ORDER_DETAIL_SUPPLEMENT :
        HL7Layout
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
        LayoutList<RGV_O15_COMPONENTS> Components { get; }
    }
}