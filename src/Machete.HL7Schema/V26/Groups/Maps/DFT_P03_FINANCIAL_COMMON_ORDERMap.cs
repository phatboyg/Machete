// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P03_FINANCIAL_COMMON_ORDER (GroupMap) - 
    /// </summary>
    public class DFT_P03_FINANCIAL_COMMON_ORDERMap :
        HL7V26LayoutMap<DFT_P03_FINANCIAL_COMMON_ORDER>
    {
        public DFT_P03_FINANCIAL_COMMON_ORDERMap()
        {
            Segment(x => x.ORC, 0);
            Layout(x => x.FinancialTimingQuantity, 1);
            Layout(x => x.FinancialOrder, 2);
            Layout(x => x.FinancialObservation, 3);
        }
    }
}