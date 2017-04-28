// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAS_O17_ORDER (GroupMap) - 
    /// </summary>
    public class RAS_O17_ORDERMap :
        HL7TemplateMap<RAS_O17_ORDER>
    {
        public RAS_O17_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OrderDetail, 2);
            Map(x => x.Encoding, 3);
            Map(x => x.Administration, 4, x => x.Required = true);
            Map(x => x.CTI, 5);
        }
    }
}