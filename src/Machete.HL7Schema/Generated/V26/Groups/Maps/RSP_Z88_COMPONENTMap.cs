// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z88_COMPONENT (GroupMap) - 
    /// </summary>
    public class RSP_Z88_COMPONENTMap :
        HL7TemplateMap<RSP_Z88_COMPONENT>
    {
        public RSP_Z88_COMPONENTMap()
        {
            Segments(x => x.RXC, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}