// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPA_I08 (MessageMap) - 
    /// </summary>
    public class RPA_I08Map :
        HL7TemplateMap<RPA_I08>
    {
        public RPA_I08Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.RF1, 4);
            Map(x => x.Authorization, 5);
            Map(x => x.Provider, 6, x => x.Required = true);
            Map(x => x.PID, 7, x => x.Required = true);
            Map(x => x.NK1, 8);
            Map(x => x.GT1, 9);
            Map(x => x.Insurance, 10);
            Map(x => x.ACC, 11);
            Map(x => x.DG1, 12);
            Map(x => x.DRG, 13);
            Map(x => x.AL1, 14);
            Map(x => x.Procedure, 15, x => x.Required = true);
            Map(x => x.Observation, 16);
            Map(x => x.Visit, 17);
            Map(x => x.NTE, 18);
        }
    }
}