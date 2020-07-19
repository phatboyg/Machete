// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORR_O02 (MessageMap) - 
    /// </summary>
    public class ORR_O02Map :
        HL7V26LayoutMap<ORR_O02>
    {
        public ORR_O02Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segment(x => x.ERR, 2);
            Segment(x => x.NTE, 3);
            Layout(x => x.Response, 4);
        }
    }
}