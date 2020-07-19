// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMI_O23_ORDER (GroupMap) - 
    /// </summary>
    public class OMI_O23_ORDERMap :
        HL7V26LayoutMap<OMI_O23_ORDER>
    {
        public OMI_O23_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Segment(x => x.OBR, 2, x => x.Required = true);
            Segment(x => x.NTE, 3);
            Segment(x => x.ROL, 4);
            Segment(x => x.CTD, 5);
            Segment(x => x.DG1, 6);
            Layout(x => x.Observation, 7);
            Segment(x => x.IPC, 8, x => x.Required = true);
        }
    }
}