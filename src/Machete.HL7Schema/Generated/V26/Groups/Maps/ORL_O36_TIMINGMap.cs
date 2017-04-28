// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORL_O36_TIMING (GroupMap) - 
    /// </summary>
    public class ORL_O36_TIMINGMap :
        HL7TemplateMap<ORL_O36_TIMING>
    {
        public ORL_O36_TIMINGMap()
        {
            Map(x => x.TQ1, 0, x => x.Required = true);
            Map(x => x.TQ2, 1);
        }
    }
}