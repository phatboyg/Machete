// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P11_FINANCIAL (GroupMap) - 
    /// </summary>
    public class DFT_P11_FINANCIALMap :
        HL7V26LayoutMap<DFT_P11_FINANCIAL>
    {
        public DFT_P11_FINANCIALMap()
        {
            Segment(x => x.FT1, 0, x => x.Required = true);
            Layout(x => x.FinancialProcedure, 1);
            Layout(x => x.FinancialCommonOrder, 2);
            Segment(x => x.DG1, 3);
            Segment(x => x.DRG, 4);
            Segment(x => x.GT1, 5);
            Layout(x => x.FinancialInsurance, 6);
        }
    }
}