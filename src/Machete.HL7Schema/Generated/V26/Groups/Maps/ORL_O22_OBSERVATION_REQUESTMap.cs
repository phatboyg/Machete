// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORL_O22_OBSERVATION_REQUEST (GroupMap) - 
    /// </summary>
    public class ORL_O22_OBSERVATION_REQUESTMap :
        HL7TemplateMap<ORL_O22_OBSERVATION_REQUEST>
    {
        public ORL_O22_OBSERVATION_REQUESTMap()
        {
            Map(x => x.OBR, 0, x => x.Required = true);
            Map(x => x.ROL, 1);
            Map(x => x.Specimen, 2);
        }
    }
}