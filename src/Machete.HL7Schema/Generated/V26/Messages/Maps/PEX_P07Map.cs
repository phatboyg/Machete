// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEX_P07 (MessageMap) - 
    /// </summary>
    public class PEX_P07Map :
        HL7TemplateMap<PEX_P07>
    {
        public PEX_P07Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EVN, 3, x => x.Required = true);
            Map(x => x.PID, 4, x => x.Required = true);
            Map(x => x.PD1, 5);
            Map(x => x.NTE, 6);
            Map(x => x.Visit, 7);
            Map(x => x.Experience, 8, x => x.Required = true);
        }
    }
}