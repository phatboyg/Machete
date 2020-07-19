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
        HL7V26LayoutMap<SRM_S01_LOCATION_RESOURCE>
    {
        public SRM_S01_LOCATION_RESOURCEMap()
        {
            Segment(x => x.AIL, 0, x => x.Required = true);
            Segment(x => x.APR, 1);
            Segment(x => x.NTE, 2);
        }
    }
}