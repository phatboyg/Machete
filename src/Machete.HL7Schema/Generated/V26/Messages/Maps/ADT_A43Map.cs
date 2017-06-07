// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A43 (MessageMap) - 
    /// </summary>
    public class ADT_A43Map :
        HL7V26LayoutMap<ADT_A43>
    {
        public ADT_A43Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Layout(x => x.Patient, 4, x => x.Required = true);
        }
    }
}