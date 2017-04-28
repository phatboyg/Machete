// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MDM_T02 (MessageMap) - 
    /// </summary>
    public class MDM_T02Map :
        HL7TemplateMap<MDM_T02>
    {
        public MDM_T02Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EVN, 3, x => x.Required = true);
            Map(x => x.PID, 4, x => x.Required = true);
            Map(x => x.PV1, 5, x => x.Required = true);
            Map(x => x.CommonOrder, 6);
            Map(x => x.TXA, 7, x => x.Required = true);
            Map(x => x.Observation, 8, x => x.Required = true);
        }
    }
}