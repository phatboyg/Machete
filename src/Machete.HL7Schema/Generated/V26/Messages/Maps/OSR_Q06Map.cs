// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OSR_Q06 (MessageMap) - 
    /// </summary>
    public class OSR_Q06Map :
        HL7TemplateMap<OSR_Q06>
    {
        public OSR_Q06Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.MSA, 1, x => x.Required = true);
            Map(x => x.ERR, 2);
            Map(x => x.SFT, 3);
            Map(x => x.UAC, 4);
            Map(x => x.NTE, 5);
            Map(x => x.QRD, 6, x => x.Required = true);
            Map(x => x.QRF, 7);
            Map(x => x.Response, 8);
            Map(x => x.DSC, 9);
        }
    }
}