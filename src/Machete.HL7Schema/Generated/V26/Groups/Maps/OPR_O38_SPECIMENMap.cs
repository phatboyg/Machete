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
            Segment(x => x.SPM, 0, x => x.Required = true);
            Segments(x => x.OBX, 1);
            Segments(x => x.SAC, 2);
            Groups(x => x.ObservationRequest, 3);
            Groups(x => x.Timing, 4);
        }
    }
}