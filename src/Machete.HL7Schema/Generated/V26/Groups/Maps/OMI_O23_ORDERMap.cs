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
        HL7TemplateMap<OMI_O23_ORDER>
    {
        public OMI_O23_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Segment(x => x.OBR, 2, x => x.Required = true);
            Segments(x => x.NTE, 3);
            Segments(x => x.ROL, 4);
            Segment(x => x.CTD, 5);
            Segments(x => x.DG1, 6);
            Groups(x => x.Observation, 7);
            Segments(x => x.IPC, 8, x => x.Required = true);
        }
    }
}