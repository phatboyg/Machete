// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORR_O02_ORDER (GroupMap) - 
    /// </summary>
    public class ORR_O02_ORDERMap :
        HL7TemplateMap<ORR_O02_ORDER>
    {
        public ORR_O02_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.OBR, 1, x => x.Required = true);
            Map(x => x.RQD, 2, x => x.Required = true);
            Map(x => x.RQ1, 3, x => x.Required = true);
            Map(x => x.RXO, 4, x => x.Required = true);
            Map(x => x.ODS, 5, x => x.Required = true);
            Map(x => x.ODT, 6, x => x.Required = true);
            Map(x => x.NTE, 7);
            Map(x => x.CTI, 8);
        }
    }
}