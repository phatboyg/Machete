// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRG_O16_GIVE (GroupMap) - 
    /// </summary>
    public class RRG_O16_GIVEMap :
        HL7TemplateMap<RRG_O16_GIVE>
    {
        public RRG_O16_GIVEMap()
        {
            Map(x => x.RXG, 0, x => x.Required = true);
            Map(x => x.TimingGive, 1, x => x.Required = true);
            Map(x => x.RXR, 2, x => x.Required = true);
            Map(x => x.RXC, 3);
        }
    }
}