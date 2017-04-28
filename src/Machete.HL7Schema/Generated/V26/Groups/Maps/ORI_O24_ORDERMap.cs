// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORI_O24_ORDER (GroupMap) - 
    /// </summary>
    public class ORI_O24_ORDERMap :
        HL7TemplateMap<ORI_O24_ORDER>
    {
        public ORI_O24_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OBR, 2, x => x.Required = true);
            Map(x => x.NTE, 3);
            Map(x => x.ROL, 4);
            Map(x => x.IPC, 5, x => x.Required = true);
        }
    }
}