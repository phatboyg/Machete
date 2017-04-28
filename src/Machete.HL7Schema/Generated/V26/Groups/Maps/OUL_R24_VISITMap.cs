// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R24_VISIT (GroupMap) - 
    /// </summary>
    public class OUL_R24_VISITMap :
        HL7TemplateMap<OUL_R24_VISIT>
    {
        public OUL_R24_VISITMap()
        {
            Map(x => x.PV1, 0, x => x.Required = true);
            Map(x => x.PV2, 1);
        }
    }
}