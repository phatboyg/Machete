// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E02 (MessageMap) - 
    /// </summary>
    public class EHC_E02Map :
        HL7TemplateMap<EHC_E02>
    {
        public EHC_E02Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segments(x => x.UAC, 2);
            Segment(x => x.IVC, 3, x => x.Required = true);
            Segment(x => x.PYE, 4, x => x.Required = true);
            Segments(x => x.CTD, 5);
            Segments(x => x.NTE, 6);
            Groups(x => x.ProductServiceSection, 7);
        }
    }
}