// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SIU_S12_RESOURCES (GroupMap) - 
    /// </summary>
    public class SIU_S12_RESOURCESMap :
        HL7TemplateMap<SIU_S12_RESOURCES>
    {
        public SIU_S12_RESOURCESMap()
        {
            Map(x => x.RGS, 0, x => x.Required = true);
            Map(x => x.Service, 1);
            Map(x => x.GeneralResource, 2);
            Map(x => x.LocationResource, 3);
            Map(x => x.PersonnelResource, 4);
        }
    }
}