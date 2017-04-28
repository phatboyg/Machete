// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E15 (MessageMap) - 
    /// </summary>
    public class EHC_E15Map :
        HL7TemplateMap<EHC_E15>
    {
        public EHC_E15Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.PMT, 3, x => x.Required = true);
            Map(x => x.PYE, 4, x => x.Required = true);
            Map(x => x.PaymentRemittanceDetailInfo, 5);
            Map(x => x.AdjustmentPayee, 6);
        }
    }
}