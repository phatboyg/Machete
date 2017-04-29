// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E15_ADJUSTMENT_PAYEE (GroupMap) - 
    /// </summary>
    public class EHC_E15_ADJUSTMENT_PAYEEMap :
        HL7TemplateMap<EHC_E15_ADJUSTMENT_PAYEE>
    {
        public EHC_E15_ADJUSTMENT_PAYEEMap()
        {
            Segment(x => x.ADJ, 0, x => x.Required = true);
            Segment(x => x.ROL, 1);
        }
    }
}