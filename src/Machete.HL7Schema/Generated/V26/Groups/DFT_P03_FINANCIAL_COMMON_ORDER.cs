// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// DFT_P03_FINANCIAL_COMMON_ORDER (Group) - 
    /// </summary>
    public interface DFT_P03_FINANCIAL_COMMON_ORDER :
        HL7Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// FINANCIAL_TIMING_QUANTITY
        /// </summary>
        LayoutList<DFT_P03_FINANCIAL_TIMING_QUANTITY> FinancialTimingQuantity { get; }

        /// <summary>
        /// FINANCIAL_ORDER
        /// </summary>
        Layout<DFT_P03_FINANCIAL_ORDER> FinancialOrder { get; }

        /// <summary>
        /// FINANCIAL_OBSERVATION
        /// </summary>
        LayoutList<DFT_P03_FINANCIAL_OBSERVATION> FinancialObservation { get; }
    }
}