// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGR_RGR_ENCODING (GroupMap) - 
    /// </summary>
    public class RGR_RGR_ENCODINGMap :
        HL7TemplateMap<RGR_RGR_ENCODING>
    {
        public RGR_RGR_ENCODINGMap()
        {
            Map(x => x.RXE, 0, x => x.Required = true);
            Map(x => x.RXR, 1, x => x.Required = true);
            Map(x => x.RXC, 2);
        }
    }
}