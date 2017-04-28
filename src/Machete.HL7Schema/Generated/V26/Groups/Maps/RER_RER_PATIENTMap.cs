// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RER_RER_PATIENT (GroupMap) - 
    /// </summary>
    public class RER_RER_PATIENTMap :
        HL7TemplateMap<RER_RER_PATIENT>
    {
        public RER_RER_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}