// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORR_O02 (MessageMap) - 
    /// </summary>
    public class ORR_O02Map :
        HL7TemplateMap<ORR_O02>
    {
        public ORR_O02Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.MSA, 1, x => x.Required = true);
            Map(x => x.ERR, 2);
            Map(x => x.NTE, 3);
            Map(x => x.Response, 4);
        }
    }
}