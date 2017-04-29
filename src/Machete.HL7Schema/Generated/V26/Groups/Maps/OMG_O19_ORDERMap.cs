// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMG_O19_ORDER (GroupMap) - 
    /// </summary>
    public class OMG_O19_ORDERMap :
        HL7TemplateMap<OMG_O19_ORDER>
    {
        public OMG_O19_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Segment(x => x.OBR, 2, x => x.Required = true);
            Segments(x => x.NTE, 3);
            Segments(x => x.ROL, 4);
            Segment(x => x.CTD, 5);
            Segments(x => x.DG1, 6);
            Groups(x => x.Observation, 7);
            Groups(x => x.Specimen, 8);
            Groups(x => x.PriorResult, 9);
            Segments(x => x.FT1, 10);
            Segments(x => x.CTI, 11);
            Segment(x => x.BLG, 12);
        }
    }
}