// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPR_O38_SPECIMEN (GroupMap) - 
    /// </summary>
    public class OPR_O38_SPECIMENMap :
        HL7TemplateMap<OPR_O38_SPECIMEN>
    {
        public OPR_O38_SPECIMENMap()
        {
            Map(x => x.SPM, 0, x => x.Required = true);
            Map(x => x.OBX, 1);
            Map(x => x.SAC, 2);
            Map(x => x.ObservationRequest, 3);
            Map(x => x.Timing, 4);
        }
    }
}