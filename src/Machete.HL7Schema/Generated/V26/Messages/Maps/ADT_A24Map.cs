// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A24 (MessageMap) - 
    /// </summary>
    public class ADT_A24Map :
        HL7TemplateMap<ADT_A24>
    {
        public ADT_A24Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PD1, 5);
            Segment(x => x.PV1, 6);
            Segments(x => x.DB1, 7);
            Segment(x => x.PID2, 8, x => x.Required = true);
            Segment(x => x.PD12, 9);
            Segment(x => x.PV12, 10);
            Segments(x => x.DB12, 11);
        }
    }
}