// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E20_PAT_INFO (GroupMap) - 
    /// </summary>
    public class EHC_E20_PAT_INFOMap :
        HL7TemplateMap<EHC_E20_PAT_INFO>
    {
        public EHC_E20_PAT_INFOMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.ACC, 1);
            Map(x => x.Insurance, 2, x => x.Required = true);
            Map(x => x.Diagnosis, 3);
            Map(x => x.OBX, 4);
        }
    }
}