// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPR_O38_OBSERVATION_REQUEST (GroupMap) - 
    /// </summary>
    public class OPR_O38_OBSERVATION_REQUESTMap :
        HL7V26LayoutMap<OPR_O38_OBSERVATION_REQUEST>
    {
        public OPR_O38_OBSERVATION_REQUESTMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Segment(x => x.OBR, 1, x => x.Required = true);
            Segment(x => x.ROL, 2);
        }
    }
}