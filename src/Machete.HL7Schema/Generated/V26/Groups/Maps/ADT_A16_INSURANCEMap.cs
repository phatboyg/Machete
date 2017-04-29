// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A16_INSURANCE (GroupMap) - 
    /// </summary>
    public class ADT_A16_INSURANCEMap :
        HL7TemplateMap<ADT_A16_INSURANCE>
    {
        public ADT_A16_INSURANCEMap()
        {
            Segment(x => x.IN1, 0, x => x.Required = true);
            Segment(x => x.IN2, 1);
            Segments(x => x.IN3, 2);
            Segments(x => x.ROL, 3);
        }
    }
}