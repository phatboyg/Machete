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
        HL7TemplateMap<DFT_P11_FINANCIAL>
    {
        public DFT_P11_FINANCIALMap()
        {
            Map(x => x.FT1, 0, x => x.Required = true);
            Map(x => x.FinancialProcedure, 1);
            Map(x => x.FinancialCommonOrder, 2);
            Map(x => x.DG1, 3);
            Map(x => x.DRG, 4);
            Map(x => x.GT1, 5);
            Map(x => x.FinancialInsurance, 6);
        }
    }
}