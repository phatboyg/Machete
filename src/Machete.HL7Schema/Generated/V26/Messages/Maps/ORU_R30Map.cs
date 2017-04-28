// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORU_R30 (MessageMap) - 
    /// </summary>
    public class ORU_R30Map :
        HL7TemplateMap<ORU_R30>
    {
        public ORU_R30Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.PID, 3, x => x.Required = true);
            Map(x => x.PD1, 4);
            Map(x => x.OBX, 5);
            Map(x => x.Visit, 6);
            Map(x => x.ORC, 7, x => x.Required = true);
            Map(x => x.OBR, 8, x => x.Required = true);
            Map(x => x.NTE, 9);
            Map(x => x.ROL, 10);
            Map(x => x.TimingQty, 11);
            Map(x => x.Observation, 12, x => x.Required = true);
        }
    }
}