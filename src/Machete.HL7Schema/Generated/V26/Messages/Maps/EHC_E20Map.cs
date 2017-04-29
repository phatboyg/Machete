// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E20 (MessageMap) - 
    /// </summary>
    public class EHC_E20Map :
        HL7TemplateMap<EHC_E20>
    {
        public EHC_E20Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segments(x => x.UAC, 2);
            Segment(x => x.IVC, 3, x => x.Required = true);
            Segments(x => x.CTD, 4, x => x.Required = true);
            Segments(x => x.LOC, 5);
            Segments(x => x.ROL, 6);
            Groups(x => x.PatInfo, 7, x => x.Required = true);
            Groups(x => x.PslItemInfo, 8, x => x.Required = true);
        }
    }
}