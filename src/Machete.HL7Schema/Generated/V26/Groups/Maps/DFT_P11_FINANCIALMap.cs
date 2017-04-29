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
            Segment(x => x.FT1, 0, x => x.Required = true);
            Groups(x => x.FinancialProcedure, 1);
            Groups(x => x.FinancialCommonOrder, 2);
            Segments(x => x.DG1, 3);
            Segment(x => x.DRG, 4);
            Segments(x => x.GT1, 5);
            Groups(x => x.FinancialInsurance, 6);
        }
    }
}