// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRA_O18_PATIENT (GroupMap) - 
    /// </summary>
    public class RRA_O18_PATIENTMap :
        HL7TemplateMap<RRA_O18_PATIENT>
    {
        public RRA_O18_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}