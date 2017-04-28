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
            Map(x => x.EVN, 0);
            Map(x => x.PID, 1, x => x.Required = true);
            Map(x => x.PD1, 2);
            Map(x => x.ARV, 3);
            Map(x => x.ROL, 4);
            Map(x => x.NK1, 5);
            Map(x => x.PV1, 6, x => x.Required = true);
            Map(x => x.PV2, 7);
            Map(x => x.ARV2, 8);
            Map(x => x.ROL2, 9);
            Map(x => x.DB1, 10);
            Map(x => x.OBX, 11);
            Map(x => x.AL1, 12);
            Map(x => x.DG1, 13);
            Map(x => x.DRG, 14);
            Map(x => x.Procedure, 15);
            Map(x => x.GT1, 16);
            Map(x => x.Insurance, 17);
            Map(x => x.ACC, 18);
            Map(x => x.UB1, 19);
            Map(x => x.UB2, 20);
        }
    }
}