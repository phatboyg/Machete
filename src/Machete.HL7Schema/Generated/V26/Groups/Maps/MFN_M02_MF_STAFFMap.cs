// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M02_MF_STAFF (GroupMap) - 
    /// </summary>
    public class MFN_M02_MF_STAFFMap :
        HL7TemplateMap<MFN_M02_MF_STAFF>
    {
        public MFN_M02_MF_STAFFMap()
        {
            Map(x => x.MFE, 0, x => x.Required = true);
            Map(x => x.STF, 1, x => x.Required = true);
            Map(x => x.PRA, 2);
            Map(x => x.ORG, 3);
            Map(x => x.AFF, 4);
            Map(x => x.LAN, 5);
            Map(x => x.EDU, 6);
            Map(x => x.CER, 7);
            Map(x => x.NTE, 8);
        }
    }
}