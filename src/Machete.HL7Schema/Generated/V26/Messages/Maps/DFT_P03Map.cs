// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P03 (MessageMap) - 
    /// </summary>
    public class DFT_P03Map :
        HL7TemplateMap<DFT_P03>
    {
        public DFT_P03Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PD1, 5);
            Segments(x => x.ROL, 6);
            Segment(x => x.PV1, 7);
            Segment(x => x.PV2, 8);
            Segments(x => x.ROL2, 9);
            Segments(x => x.DB1, 10);
            Groups(x => x.CommonOrder, 11);
            Groups(x => x.Financial, 12, x => x.Required = true);
            Segments(x => x.DG1, 13);
            Segment(x => x.DRG, 14);
            Segments(x => x.GT1, 15);
            Groups(x => x.Insurance, 16);
            Segment(x => x.ACC, 17);
        }
    }
}