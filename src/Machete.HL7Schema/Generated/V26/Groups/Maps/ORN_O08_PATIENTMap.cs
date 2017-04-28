// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORN_O08_PATIENT (GroupMap) - 
    /// </summary>
    public class ORN_O08_PATIENTMap :
        HL7TemplateMap<ORN_O08_PATIENT>
    {
        public ORN_O08_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}