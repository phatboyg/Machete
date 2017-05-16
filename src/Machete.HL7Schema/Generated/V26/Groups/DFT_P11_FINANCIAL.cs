// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// DFT_P11_FINANCIAL (Group) - 
    /// </summary>
    public interface DFT_P11_FINANCIAL :
        HL7Layout
    {
        /// <summary>
        /// FT1
        /// </summary>
        Segment<FT1> FT1 { get; }

        /// <summary>
        /// FINANCIAL_PROCEDURE
        /// </summary>
        LayoutList<DFT_P11_FINANCIAL_PROCEDURE> FinancialProcedure { get; }

        /// <summary>
        /// FINANCIAL_COMMON_ORDER
        /// </summary>
        LayoutList<DFT_P11_FINANCIAL_COMMON_ORDER> FinancialCommonOrder { get; }

        /// <summary>
        /// DG1
        /// </summary>
        SegmentList<DG1> DG1 { get; }

        /// <summary>
        /// DRG
        /// </summary>
        Segment<DRG> DRG { get; }

        /// <summary>
        /// GT1
        /// </summary>
        SegmentList<GT1> GT1 { get; }

        /// <summary>
        /// FINANCIAL_INSURANCE
        /// </summary>
        LayoutList<DFT_P11_FINANCIAL_INSURANCE> FinancialInsurance { get; }
    }
}