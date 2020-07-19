// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// DFT_P03_COMMON_ORDER (Group) - 
    /// </summary>
    public interface DFT_P03_COMMON_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING_QUANTITY
        /// </summary>
        LayoutList<DFT_P03_TIMING_QUANTITY> TimingQuantity { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        Layout<DFT_P03_ORDER> Order { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<DFT_P03_OBSERVATION> Observation { get; }
    }
}