// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OSR_Q06_ORDER (GroupMap) - 
    /// </summary>
    public class OSR_Q06_ORDERMap :
        HL7TemplateMap<OSR_Q06_ORDER>
    {
        public OSR_Q06_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OBR, 2, x => x.Required = true);
            Map(x => x.RQD, 3, x => x.Required = true);
            Map(x => x.RQ1, 4, x => x.Required = true);
            Map(x => x.RXO, 5, x => x.Required = true);
            Map(x => x.ODS, 6, x => x.Required = true);
            Map(x => x.ODT, 7, x => x.Required = true);
            Map(x => x.NTE, 8);
            Map(x => x.CTI, 9);
        }
    }
}