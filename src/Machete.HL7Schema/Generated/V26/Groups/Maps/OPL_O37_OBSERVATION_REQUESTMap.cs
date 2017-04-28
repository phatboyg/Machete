// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_OBSERVATION_REQUEST (GroupMap) - 
    /// </summary>
    public class OPL_O37_OBSERVATION_REQUESTMap :
        HL7TemplateMap<OPL_O37_OBSERVATION_REQUEST>
    {
        public OPL_O37_OBSERVATION_REQUESTMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.OBR, 1, x => x.Required = true);
            Map(x => x.ROL, 2);
            Map(x => x.Timing, 3);
            Map(x => x.TCD, 4);
            Map(x => x.DG1, 5);
            Map(x => x.OBX, 6);
        }
    }
}