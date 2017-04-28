// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O35_OBSERVATION_REQUEST (GroupMap) - 
    /// </summary>
    public class OML_O35_OBSERVATION_REQUESTMap :
        HL7TemplateMap<OML_O35_OBSERVATION_REQUEST>
    {
        public OML_O35_OBSERVATION_REQUESTMap()
        {
            Map(x => x.OBR, 0, x => x.Required = true);
            Map(x => x.TCD, 1);
            Map(x => x.NTE, 2);
            Map(x => x.ROL, 3);
            Map(x => x.DG1, 4);
            Map(x => x.Observation, 5);
            Map(x => x.PriorResult, 6);
        }
    }
}