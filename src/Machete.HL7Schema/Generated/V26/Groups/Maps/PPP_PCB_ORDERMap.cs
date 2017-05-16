// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPP_PCB_ORDER (GroupMap) - 
    /// </summary>
    public class PPP_PCB_ORDERMap :
        HL7LayoutMap<PPP_PCB_ORDER>
    {
        public PPP_PCB_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.OrderDetail, 1);
        }
    }
}