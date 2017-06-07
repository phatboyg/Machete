// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQM_S25_REQUEST (GroupMap) - 
    /// </summary>
    public class SQM_S25_REQUESTMap :
        HL7V26LayoutMap<SQM_S25_REQUEST>
    {
        public SQM_S25_REQUESTMap()
        {
            Segment(x => x.ARQ, 0, x => x.Required = true);
            Segment(x => x.APR, 1);
            Segment(x => x.PID, 2);
            Layout(x => x.Resources, 3, x => x.Required = true);
        }
    }
}