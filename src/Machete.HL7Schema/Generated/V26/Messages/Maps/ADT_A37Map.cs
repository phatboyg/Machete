// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A37 (MessageMap) - 
    /// </summary>
    public class ADT_A37Map :
        HL7TemplateMap<ADT_A37>
    {
        public ADT_A37Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EVN, 3, x => x.Required = true);
            Map(x => x.PID, 4, x => x.Required = true);
            Map(x => x.PD1, 5);
            Map(x => x.PV1, 6);
            Map(x => x.DB1, 7);
            Map(x => x.PID2, 8, x => x.Required = true);
            Map(x => x.PD12, 9);
            Map(x => x.PV12, 10);
            Map(x => x.DB12, 11);
        }
    }
}