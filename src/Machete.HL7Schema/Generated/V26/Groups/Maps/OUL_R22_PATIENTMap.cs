// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R22_PATIENT (GroupMap) - 
    /// </summary>
    public class OUL_R22_PATIENTMap :
        HL7TemplateMap<OUL_R22_PATIENT>
    {
        public OUL_R22_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Segments(x => x.NTE, 2);
            Segments(x => x.OBX, 3);
            Group(x => x.Visit, 4);
        }
    }
}