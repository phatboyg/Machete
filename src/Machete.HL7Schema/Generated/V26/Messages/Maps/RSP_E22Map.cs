// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_E22 (MessageMap) - 
    /// </summary>
    public class RSP_E22Map :
        HL7TemplateMap<RSP_E22>
    {
        public RSP_E22Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.ERR, 4);
            Map(x => x.QAK, 5, x => x.Required = true);
            Map(x => x.QPD, 6, x => x.Required = true);
            Map(x => x.AuthorizationInfo, 7);
        }
    }
}