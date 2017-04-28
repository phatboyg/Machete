// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORB_O28_PATIENT (GroupMap) - 
    /// </summary>
    public class ORB_O28_PATIENTMap :
        HL7TemplateMap<ORB_O28_PATIENT>
    {
        public ORB_O28_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.Order, 1);
        }
    }
}