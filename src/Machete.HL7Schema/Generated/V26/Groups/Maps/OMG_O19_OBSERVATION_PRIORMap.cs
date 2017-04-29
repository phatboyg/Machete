// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMG_O19_OBSERVATION_PRIOR (GroupMap) - 
    /// </summary>
    public class OMG_O19_OBSERVATION_PRIORMap :
        HL7TemplateMap<OMG_O19_OBSERVATION_PRIOR>
    {
        public OMG_O19_OBSERVATION_PRIORMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}