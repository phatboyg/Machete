// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P11_FINANCIAL_COMMON_ORDER (GroupMap) - 
    /// </summary>
    public class DFT_P11_FINANCIAL_COMMON_ORDERMap :
        HL7TemplateMap<DFT_P11_FINANCIAL_COMMON_ORDER>
    {
        public DFT_P11_FINANCIAL_COMMON_ORDERMap()
        {
            Map(x => x.ORC, 0);
            Map(x => x.FinancialTimingQuantity, 1);
            Map(x => x.FinancialOrder, 2);
            Map(x => x.FinancialObservation, 3);
        }
    }
}