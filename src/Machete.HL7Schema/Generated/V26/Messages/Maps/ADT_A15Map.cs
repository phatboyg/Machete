// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A15 (MessageMap) - 
    /// </summary>
    public class ADT_A15Map :
        HL7TemplateMap<ADT_A15>
    {
        public ADT_A15Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PD1, 5);
            Segments(x => x.ARV, 6);
            Segments(x => x.ROL, 7);
            Segment(x => x.PV1, 8, x => x.Required = true);
            Segment(x => x.PV2, 9);
            Segments(x => x.ARV2, 10);
            Segments(x => x.ROL2, 11);
            Segments(x => x.DB1, 12);
            Segments(x => x.OBX, 13);
            Segments(x => x.DG1, 14);
        }
    }
}