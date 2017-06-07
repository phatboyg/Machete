// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SSR_U04 (MessageMap) - 
    /// </summary>
    public class SSR_U04Map :
        HL7V26LayoutMap<SSR_U04>
    {
        public SSR_U04Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EQU, 3, x => x.Required = true);
            Layout(x => x.SpecimenContainer, 4, x => x.Required = true);
            Segment(x => x.ROL, 5);
        }
    }
}