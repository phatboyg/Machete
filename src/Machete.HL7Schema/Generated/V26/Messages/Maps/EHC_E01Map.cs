// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E01 (MessageMap) - 
    /// </summary>
    public class EHC_E01Map :
        HL7TemplateMap<EHC_E01>
    {
        public EHC_E01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segments(x => x.UAC, 2);
            Segment(x => x.IVC, 3, x => x.Required = true);
            Segment(x => x.PYE, 4);
            Segments(x => x.CTD, 5);
            Segment(x => x.AUT, 6);
            Segments(x => x.LOC, 7);
            Segments(x => x.ROL, 8);
            Groups(x => x.ProductServiceSection, 9, x => x.Required = true);
        }
    }
}