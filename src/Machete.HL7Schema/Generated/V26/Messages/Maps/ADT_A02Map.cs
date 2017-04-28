// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A02 (MessageMap) - 
    /// </summary>
    public class ADT_A02Map :
        HL7TemplateMap<ADT_A02>
    {
        public ADT_A02Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EVN, 3, x => x.Required = true);
            Map(x => x.PID, 4, x => x.Required = true);
            Map(x => x.PD1, 5);
            Map(x => x.ARV, 6);
            Map(x => x.ROL, 7);
            Map(x => x.PV1, 8, x => x.Required = true);
            Map(x => x.PV2, 9);
            Map(x => x.ARV2, 10);
            Map(x => x.ROL2, 11);
            Map(x => x.DB1, 12);
            Map(x => x.OBX, 13);
            Map(x => x.PDA, 14);
        }
    }
}