// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMG_O19_TIMING (GroupMap) - 
    /// </summary>
    public class OMG_O19_TIMINGMap :
        HL7TemplateMap<OMG_O19_TIMING>
    {
        public OMG_O19_TIMINGMap()
        {
            Map(x => x.TQ1, 0, x => x.Required = true);
            Map(x => x.TQ2, 1);
        }
    }
}