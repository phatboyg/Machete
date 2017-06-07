// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E20_INSURANCE (GroupMap) - 
    /// </summary>
    public class EHC_E20_INSURANCEMap :
        HL7V26LayoutMap<EHC_E20_INSURANCE>
    {
        public EHC_E20_INSURANCEMap()
        {
            Segment(x => x.IN1, 0, x => x.Required = true);
            Segment(x => x.IN2, 1);
        }
    }
}