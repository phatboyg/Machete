// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z88_VISIT (GroupMap) - 
    /// </summary>
    public class RSP_Z88_VISITMap :
        HL7TemplateMap<RSP_Z88_VISIT>
    {
        public RSP_Z88_VISITMap()
        {
            Map(x => x.PV1, 0, x => x.Required = true);
            Map(x => x.PV2, 1);
        }
    }
}