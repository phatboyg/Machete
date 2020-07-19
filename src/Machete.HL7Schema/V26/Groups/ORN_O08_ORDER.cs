// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORN_O08_ORDER (Group) - 
    /// </summary>
    public interface ORN_O08_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<ORN_O08_TIMING> Timing { get; }

        /// <summary>
        /// RQD
        /// </summary>
        Segment<RQD> RQD { get; }

        /// <summary>
        /// RQ1
        /// </summary>
        Segment<RQ1> RQ1 { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}