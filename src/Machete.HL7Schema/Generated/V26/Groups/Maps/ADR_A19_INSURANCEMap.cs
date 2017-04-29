// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADR_A19_INSURANCE (GroupMap) - 
    /// </summary>
    public class ADR_A19_INSURANCEMap :
        HL7TemplateMap<ADR_A19_INSURANCE>
    {
        public ADR_A19_INSURANCEMap()
        {
            Segment(x => x.IN1, 0, x => x.Required = true);
            Segment(x => x.IN2, 1);
            Segments(x => x.IN3, 2);
            Segments(x => x.ROL, 3);
        }
    }
}