// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDR_RDR (MessageMap) - 
    /// </summary>
    public class RDR_RDRMap :
        HL7TemplateMap<RDR_RDR>
    {
        public RDR_RDRMap()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.MSA, 1, x => x.Required = true);
            Map(x => x.ERR, 2);
            Map(x => x.SFT, 3);
            Map(x => x.SFT2, 4);
            Map(x => x.UAC, 5);
            Map(x => x.Definition, 6, x => x.Required = true);
            Map(x => x.RXC, 7);
            Map(x => x.DSC, 8);
            Map(x => x.RXD, 9, x => x.Required = true);
            Map(x => x.RXR, 10, x => x.Required = true);
            Map(x => x.RXC2, 11);
            Map(x => x.DSC2, 12);
        }
    }
}