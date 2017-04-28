// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRE_O12 (MessageMap) - 
    /// </summary>
    public class RRE_O12Map :
        HL7TemplateMap<RRE_O12>
    {
        public RRE_O12Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.MSA, 1, x => x.Required = true);
            Map(x => x.ERR, 2);
            Map(x => x.SFT, 3);
            Map(x => x.UAC, 4);
            Map(x => x.NTE, 5);
            Map(x => x.Response, 6);
        }
    }
}