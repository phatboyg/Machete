// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQA_I08 (MessageMap) - 
    /// </summary>
    public class RQA_I08Map :
        HL7TemplateMap<RQA_I08>
    {
        public RQA_I08Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.RF1, 3);
            Map(x => x.Authorization, 4);
            Map(x => x.Provider, 5, x => x.Required = true);
            Map(x => x.PID, 6, x => x.Required = true);
            Map(x => x.NK1, 7);
            Map(x => x.GuarantorInsurance, 8);
            Map(x => x.ACC, 9);
            Map(x => x.DG1, 10);
            Map(x => x.DRG, 11);
            Map(x => x.AL1, 12);
            Map(x => x.Procedure, 13);
            Map(x => x.Observation, 14);
            Map(x => x.Visit, 15);
            Map(x => x.NTE, 16);
        }
    }
}