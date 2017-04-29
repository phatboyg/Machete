// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORD_O04_PATIENT (GroupMap) - 
    /// </summary>
    public class ORD_O04_PATIENTMap :
        HL7TemplateMap<ORD_O04_PATIENT>
    {
        public ORD_O04_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}