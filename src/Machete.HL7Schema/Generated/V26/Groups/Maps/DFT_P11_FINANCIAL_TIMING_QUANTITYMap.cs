// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P11_FINANCIAL_TIMING_QUANTITY (GroupMap) - 
    /// </summary>
    public class DFT_P11_FINANCIAL_TIMING_QUANTITYMap :
        HL7TemplateMap<DFT_P11_FINANCIAL_TIMING_QUANTITY>
    {
        public DFT_P11_FINANCIAL_TIMING_QUANTITYMap()
        {
            Map(x => x.TQ1, 0, x => x.Required = true);
            Map(x => x.TQ2, 1);
        }
    }
}