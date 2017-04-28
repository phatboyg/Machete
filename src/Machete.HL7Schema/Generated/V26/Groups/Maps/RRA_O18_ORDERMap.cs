// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRA_O18_ORDER (GroupMap) - 
    /// </summary>
    public class RRA_O18_ORDERMap :
        HL7TemplateMap<RRA_O18_ORDER>
    {
        public RRA_O18_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.Administration, 2);
        }
    }
}