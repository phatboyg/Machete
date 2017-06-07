// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P03_FINANCIAL (GroupMap) - 
    /// </summary>
    public class DFT_P03_FINANCIALMap :
        HL7V26LayoutMap<DFT_P03_FINANCIAL>
    {
        public DFT_P03_FINANCIALMap()
        {
            Segment(x => x.FT1, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Layout(x => x.FinancialProcedure, 2);
            Layout(x => x.FinancialCommonOrder, 3);
        }
    }
}