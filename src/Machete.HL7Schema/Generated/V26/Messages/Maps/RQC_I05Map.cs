// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQC_I05 (MessageMap) - 
    /// </summary>
    public class RQC_I05Map :
        HL7TemplateMap<RQC_I05>
    {
        public RQC_I05Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.QRD, 3, x => x.Required = true);
            Map(x => x.QRF, 4);
            Map(x => x.Provider, 5, x => x.Required = true);
            Map(x => x.PID, 6, x => x.Required = true);
            Map(x => x.NK1, 7);
            Map(x => x.GT1, 8);
            Map(x => x.NTE, 9);
        }
    }
}