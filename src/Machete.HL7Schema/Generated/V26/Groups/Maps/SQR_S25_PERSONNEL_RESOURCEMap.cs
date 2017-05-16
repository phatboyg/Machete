// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQR_S25_PERSONNEL_RESOURCE (GroupMap) - 
    /// </summary>
    public class SQR_S25_PERSONNEL_RESOURCEMap :
        HL7LayoutMap<SQR_S25_PERSONNEL_RESOURCE>
    {
        public SQR_S25_PERSONNEL_RESOURCEMap()
        {
            Segment(x => x.AIP, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}