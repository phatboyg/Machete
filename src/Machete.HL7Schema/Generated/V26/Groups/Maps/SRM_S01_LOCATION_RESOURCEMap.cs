// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRM_S01_LOCATION_RESOURCE (GroupMap) - 
    /// </summary>
    public class SRM_S01_LOCATION_RESOURCEMap :
        HL7TemplateMap<SRM_S01_LOCATION_RESOURCE>
    {
        public SRM_S01_LOCATION_RESOURCEMap()
        {
            Map(x => x.AIL, 0, x => x.Required = true);
            Map(x => x.APR, 1);
            Map(x => x.NTE, 2);
        }
    }
}