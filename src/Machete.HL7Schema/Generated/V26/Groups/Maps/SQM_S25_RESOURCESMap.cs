// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQM_S25_RESOURCES (GroupMap) - 
    /// </summary>
    public class SQM_S25_RESOURCESMap :
        HL7TemplateMap<SQM_S25_RESOURCES>
    {
        public SQM_S25_RESOURCESMap()
        {
            Segment(x => x.RGS, 0, x => x.Required = true);
            Groups(x => x.Service, 1);
            Groups(x => x.GeneralResource, 2);
            Groups(x => x.PersonnelResource, 3);
            Groups(x => x.LocationResource, 4);
        }
    }
}