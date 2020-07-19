// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A02 (MessageMap) - 
    /// </summary>
    public class ADT_A02Map :
        HL7V26LayoutMap<ADT_A02>
    {
        public ADT_A02Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PD1, 5);
            Segment(x => x.ARV, 6);
            Segment(x => x.ROL, 7);
            Segment(x => x.PV1, 8, x => x.Required = true);
            Segment(x => x.PV2, 9);
            Segment(x => x.ARV2, 10);
            Segment(x => x.ROL2, 11);
            Segment(x => x.DB1, 12);
            Segment(x => x.OBX, 13);
            Segment(x => x.PDA, 14);
        }
    }
}