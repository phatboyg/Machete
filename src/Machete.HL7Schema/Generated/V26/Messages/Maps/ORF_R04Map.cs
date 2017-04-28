// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORF_R04 (MessageMap) - 
    /// </summary>
    public class ORF_R04Map :
        HL7TemplateMap<ORF_R04>
    {
        public ORF_R04Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.QRD, 4, x => x.Required = true);
            Map(x => x.QRF, 5);
            Map(x => x.QueryResponse, 6, x => x.Required = true);
            Map(x => x.ERR, 7);
            Map(x => x.QAK, 8);
            Map(x => x.DSC, 9);
        }
    }
}