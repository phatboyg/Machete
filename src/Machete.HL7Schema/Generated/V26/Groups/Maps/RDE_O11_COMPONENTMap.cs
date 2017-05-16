// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDE_O11_COMPONENT (GroupMap) - 
    /// </summary>
    public class RDE_O11_COMPONENTMap :
        HL7LayoutMap<RDE_O11_COMPONENT>
    {
        public RDE_O11_COMPONENTMap()
        {
            Segment(x => x.RXC, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}