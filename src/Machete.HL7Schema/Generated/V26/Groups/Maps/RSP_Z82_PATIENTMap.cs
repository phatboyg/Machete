// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z82_PATIENT (GroupMap) - 
    /// </summary>
    public class RSP_Z82_PATIENTMap :
        HL7TemplateMap<RSP_Z82_PATIENT>
    {
        public RSP_Z82_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Segments(x => x.NTE, 2);
            Group(x => x.Visit, 3);
        }
    }
}