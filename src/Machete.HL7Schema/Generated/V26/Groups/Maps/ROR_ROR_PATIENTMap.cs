// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ROR_ROR_PATIENT (GroupMap) - 
    /// </summary>
    public class ROR_ROR_PATIENTMap :
        HL7TemplateMap<ROR_ROR_PATIENT>
    {
        public ROR_ROR_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}