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
        HL7TemplateMap<ADR_A19_QUERY_RESPONSE>
    {
        public ADR_A19_QUERY_RESPONSEMap()
        {
            Segment(x => x.EVN, 0);
            Segment(x => x.PID, 1, x => x.Required = true);
            Segment(x => x.PD1, 2);
            Segments(x => x.ARV, 3);
            Segments(x => x.ROL, 4);
            Segments(x => x.NK1, 5);
            Segment(x => x.PV1, 6, x => x.Required = true);
            Segment(x => x.PV2, 7);
            Segments(x => x.ARV2, 8);
            Segments(x => x.ROL2, 9);
            Segments(x => x.DB1, 10);
            Segments(x => x.OBX, 11);
            Segments(x => x.AL1, 12);
            Segments(x => x.DG1, 13);
            Segment(x => x.DRG, 14);
            Groups(x => x.Procedure, 15);
            Segments(x => x.GT1, 16);
            Groups(x => x.Insurance, 17);
            Segment(x => x.ACC, 18);
            Segment(x => x.UB1, 19);
            Segment(x => x.UB2, 20);
        }
    }
}