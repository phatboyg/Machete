// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQR_S25_RESOURCES (GroupMap) - 
    /// </summary>
    public class SQR_S25_RESOURCESMap :
        HL7LayoutMap<SQR_S25_RESOURCES>
    {
        public SQR_S25_RESOURCESMap()
        {
            Segment(x => x.RGS, 0, x => x.Required = true);
            Layout(x => x.Service, 1);
            Layout(x => x.GeneralResource, 2);
            Layout(x => x.PersonnelResource, 3);
            Layout(x => x.LocationResource, 4);
        }
    }
}