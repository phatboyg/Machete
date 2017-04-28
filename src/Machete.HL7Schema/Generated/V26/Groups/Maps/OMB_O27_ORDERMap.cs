// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMB_O27_ORDER (GroupMap) - 
    /// </summary>
    public class OMB_O27_ORDERMap :
        HL7TemplateMap<OMB_O27_ORDER>
    {
        public OMB_O27_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.BPO, 2, x => x.Required = true);
            Map(x => x.SPM, 3);
            Map(x => x.NTE, 4);
            Map(x => x.DG1, 5);
            Map(x => x.Observation, 6);
            Map(x => x.FT1, 7);
            Map(x => x.BLG, 8);
        }
    }
}