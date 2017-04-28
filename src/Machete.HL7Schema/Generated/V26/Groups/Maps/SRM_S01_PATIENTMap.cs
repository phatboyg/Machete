// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRM_S01_PATIENT (GroupMap) - 
    /// </summary>
    public class SRM_S01_PATIENTMap :
        HL7TemplateMap<SRM_S01_PATIENT>
    {
        public SRM_S01_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PV1, 1);
            Map(x => x.PV2, 2);
            Map(x => x.OBX, 3);
            Map(x => x.DG1, 4);
        }
    }
}