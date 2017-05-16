// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQP_I04 (MessageMap) - 
    /// </summary>
    public class RQP_I04Map :
        HL7LayoutMap<RQP_I04>
    {
        public RQP_I04Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Layout(x => x.Provider, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.NK1, 5);
            Segment(x => x.GT1, 6);
            Segment(x => x.NTE, 7);
        }
    }
}