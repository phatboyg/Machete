// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDS_O13_COMPONENT (GroupMap) - 
    /// </summary>
    public class RDS_O13_COMPONENTMap :
        HL7TemplateMap<RDS_O13_COMPONENT>
    {
        public RDS_O13_COMPONENTMap()
        {
            Segment(x => x.RXC, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}