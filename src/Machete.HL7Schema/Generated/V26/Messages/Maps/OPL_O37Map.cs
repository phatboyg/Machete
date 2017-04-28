// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37 (MessageMap) - 
    /// </summary>
    public class OPL_O37Map :
        HL7TemplateMap<OPL_O37>
    {
        public OPL_O37Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.NTE, 3);
            Map(x => x.ROL, 4, x => x.Required = true);
            Map(x => x.Guarantor, 5);
            Map(x => x.Order, 6, x => x.Required = true);
        }
    }
}