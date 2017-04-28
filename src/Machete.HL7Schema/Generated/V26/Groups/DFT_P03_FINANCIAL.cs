// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// DFT_P03_FINANCIAL (Group) - 
    /// </summary>
    public interface DFT_P03_FINANCIAL :
        HL7Template
    {
        /// <summary>
        /// FT1
        /// </summary>
        Segment<FT1> FT1 { get; }

        /// <summary>
        /// NTE
        /// </summary>
        Segment<NTE> NTE { get; }

        /// <summary>
        /// FINANCIAL_PROCEDURE
        /// </summary>
        GroupList<DFT_P03_FINANCIAL_PROCEDURE> FinancialProcedure { get; }

        /// <summary>
        /// FINANCIAL_COMMON_ORDER
        /// </summary>
        GroupList<DFT_P03_FINANCIAL_COMMON_ORDER> FinancialCommonOrder { get; }
    }
}