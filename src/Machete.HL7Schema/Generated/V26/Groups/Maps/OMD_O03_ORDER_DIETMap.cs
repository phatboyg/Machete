// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMD_O03_ORDER_DIET (GroupMap) - 
    /// </summary>
    public class OMD_O03_ORDER_DIETMap :
        HL7TemplateMap<OMD_O03_ORDER_DIET>
    {
        public OMD_O03_ORDER_DIETMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.TimingDiet, 1);
            Group(x => x.Diet, 2);
        }
    }
}