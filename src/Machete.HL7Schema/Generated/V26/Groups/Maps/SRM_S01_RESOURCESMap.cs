// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRM_S01_RESOURCES (GroupMap) - 
    /// </summary>
    public class SRM_S01_RESOURCESMap :
        HL7TemplateMap<SRM_S01_RESOURCES>
    {
        public SRM_S01_RESOURCESMap()
        {
            Map(x => x.RGS, 0, x => x.Required = true);
            Map(x => x.Service, 1);
            Map(x => x.GeneralResource, 2);
            Map(x => x.LocationResource, 3);
            Map(x => x.PersonnelResource, 4);
        }
    }
}