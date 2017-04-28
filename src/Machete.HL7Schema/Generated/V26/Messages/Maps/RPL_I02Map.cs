// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPL_I02 (MessageMap) - 
    /// </summary>
    public class RPL_I02Map :
        HL7TemplateMap<RPL_I02>
    {
        public RPL_I02Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.Provider, 4, x => x.Required = true);
            Map(x => x.NTE, 5);
            Map(x => x.DSP, 6);
            Map(x => x.DSC, 7);
        }
    }
}