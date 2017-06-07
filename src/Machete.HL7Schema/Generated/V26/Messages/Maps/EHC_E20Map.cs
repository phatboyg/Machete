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
        HL7V26LayoutMap<EHC_E20>
    {
        public EHC_E20Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.IVC, 3, x => x.Required = true);
            Segment(x => x.CTD, 4, x => x.Required = true);
            Segment(x => x.LOC, 5);
            Segment(x => x.ROL, 6);
            Layout(x => x.PatInfo, 7, x => x.Required = true);
            Layout(x => x.PslItemInfo, 8, x => x.Required = true);
        }
    }
}