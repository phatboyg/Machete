// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BAR_P06_PATIENT (GroupMap) - 
    /// </summary>
    public class BAR_P06_PATIENTMap :
        HL7TemplateMap<BAR_P06_PATIENT>
    {
        public BAR_P06_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PV1, 1);
        }
    }
}