// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORD_O04_ORDER_DIET (Group) - 
    /// </summary>
    public interface ORD_O04_ORDER_DIET :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING_DIET
        /// </summary>
        GroupList<ORD_O04_TIMING_DIET> TimingDiet { get; }

        /// <summary>
        /// ODS
        /// </summary>
        SegmentList<ODS> ODS { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}