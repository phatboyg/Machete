// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADR_A19_QUERY_RESPONSE (GroupMap) - 
    /// </summary>
    public class ADR_A19_QUERY_RESPONSEMap :
        HL7V26LayoutMap<ADR_A19_QUERY_RESPONSE>
    {
        public ADR_A19_QUERY_RESPONSEMap()
        {
            Segment(x => x.EVN, 0);
            Segment(x => x.PID, 1, x => x.Required = true);
            Segment(x => x.PD1, 2);
            Segment(x => x.ARV, 3);
            Segment(x => x.ROL, 4);
            Segment(x => x.NK1, 5);
            Segment(x => x.PV1, 6, x => x.Required = true);
            Segment(x => x.PV2, 7);
            Segment(x => x.ARV2, 8);
            Segment(x => x.ROL2, 9);
            Segment(x => x.DB1, 10);
            Segment(x => x.OBX, 11);
            Segment(x => x.AL1, 12);
            Segment(x => x.DG1, 13);
            Segment(x => x.DRG, 14);
            Layout(x => x.Procedure, 15);
            Segment(x => x.GT1, 16);
            Layout(x => x.Insurance, 17);
            Segment(x => x.ACC, 18);
            Segment(x => x.UB1, 19);
            Segment(x => x.UB2, 20);
        }
    }
}