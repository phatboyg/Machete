// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORP_O10_COMPONENT (GroupMap) - 
    /// </summary>
    public class ORP_O10_COMPONENTMap :
        HL7TemplateMap<ORP_O10_COMPONENT>
    {
        public ORP_O10_COMPONENTMap()
        {
            Map(x => x.RXC, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}