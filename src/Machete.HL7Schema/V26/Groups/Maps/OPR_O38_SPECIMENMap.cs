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
        HL7V26LayoutMap<OPR_O38_SPECIMEN>
    {
        public OPR_O38_SPECIMENMap()
        {
            Segment(x => x.SPM, 0, x => x.Required = true);
            Segment(x => x.OBX, 1);
            Segment(x => x.SAC, 2);
            Layout(x => x.ObservationRequest, 3);
            Layout(x => x.Timing, 4);
        }
    }
}