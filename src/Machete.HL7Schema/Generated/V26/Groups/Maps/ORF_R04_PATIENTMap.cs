// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORF_R04_PATIENT (GroupMap) - 
    /// </summary>
    public class ORF_R04_PATIENTMap :
        HL7TemplateMap<ORF_R04_PATIENT>
    {
        public ORF_R04_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.OBX, 2);
        }
    }
}