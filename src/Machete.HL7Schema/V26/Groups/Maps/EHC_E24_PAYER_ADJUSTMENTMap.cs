// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E24_PAYER_ADJUSTMENT (GroupMap) - 
    /// </summary>
    public class EHC_E24_PAYER_ADJUSTMENTMap :
        HL7V26LayoutMap<EHC_E24_PAYER_ADJUSTMENT>
    {
        public EHC_E24_PAYER_ADJUSTMENTMap()
        {
            Segment(x => x.ADJ, 0, x => x.Required = true);
        }
    }
}