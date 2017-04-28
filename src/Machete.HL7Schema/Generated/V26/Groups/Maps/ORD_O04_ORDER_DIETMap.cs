// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORD_O04_ORDER_DIET (GroupMap) - 
    /// </summary>
    public class ORD_O04_ORDER_DIETMap :
        HL7TemplateMap<ORD_O04_ORDER_DIET>
    {
        public ORD_O04_ORDER_DIETMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.TimingDiet, 1);
            Map(x => x.ODS, 2);
            Map(x => x.NTE, 3);
        }
    }
}