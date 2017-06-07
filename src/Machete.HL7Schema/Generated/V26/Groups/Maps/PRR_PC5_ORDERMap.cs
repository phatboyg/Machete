// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRR_PC5_ORDER (GroupMap) - 
    /// </summary>
    public class PRR_PC5_ORDERMap :
        HL7V26LayoutMap<PRR_PC5_ORDER>
    {
        public PRR_PC5_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.OrderDetail, 1);
        }
    }
}