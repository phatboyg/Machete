// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORN_O08_ORDER (GroupMap) - 
    /// </summary>
    public class ORN_O08_ORDERMap :
        HL7V26LayoutMap<ORN_O08_ORDER>
    {
        public ORN_O08_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Segment(x => x.RQD, 2, x => x.Required = true);
            Segment(x => x.RQ1, 3);
            Segment(x => x.NTE, 4);
        }
    }
}