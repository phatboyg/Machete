// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORG_O20_OBSERVATION_GROUP (GroupMap) - 
    /// </summary>
    public class ORG_O20_OBSERVATION_GROUPMap :
        HL7TemplateMap<ORG_O20_OBSERVATION_GROUP>
    {
        public ORG_O20_OBSERVATION_GROUPMap()
        {
            Map(x => x.OBR, 0, x => x.Required = true);
            Map(x => x.ROL, 1);
        }
    }
}