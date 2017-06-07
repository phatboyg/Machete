// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORB_O28 (MessageMap) - 
    /// </summary>
    public class ORB_O28Map :
        HL7V26LayoutMap<ORB_O28>
    {
        public ORB_O28Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segment(x => x.ERR, 2);
            Segment(x => x.SFT, 3);
            Segment(x => x.UAC, 4);
            Segment(x => x.NTE, 5);
            Layout(x => x.Response, 6);
        }
    }
}