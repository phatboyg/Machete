// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORR_O02_PATIENT (GroupMap) - 
    /// </summary>
    public class ORR_O02_PATIENTMap :
        HL7TemplateMap<ORR_O02_PATIENT>
    {
        public ORR_O02_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}