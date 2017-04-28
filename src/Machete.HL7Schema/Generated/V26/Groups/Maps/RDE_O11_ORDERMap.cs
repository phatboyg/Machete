// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDE_O11_ORDER (GroupMap) - 
    /// </summary>
    public class RDE_O11_ORDERMap :
        HL7TemplateMap<RDE_O11_ORDER>
    {
        public RDE_O11_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OrderDetail, 2);
            Map(x => x.RXE, 3, x => x.Required = true);
            Map(x => x.NTE, 4);
            Map(x => x.TimingEncoded, 5, x => x.Required = true);
            Map(x => x.RXR, 6, x => x.Required = true);
            Map(x => x.RXC, 7);
            Map(x => x.Observation, 8);
            Map(x => x.FT1, 9);
            Map(x => x.BLG, 10);
            Map(x => x.CTI, 11);
        }
    }
}