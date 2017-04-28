// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAR_RAR_ENCODING (GroupMap) - 
    /// </summary>
    public class RAR_RAR_ENCODINGMap :
        HL7TemplateMap<RAR_RAR_ENCODING>
    {
        public RAR_RAR_ENCODINGMap()
        {
            Map(x => x.RXE, 0, x => x.Required = true);
            Map(x => x.RXR, 1, x => x.Required = true);
            Map(x => x.RXC, 2);
        }
    }
}