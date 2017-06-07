// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E24 (MessageMap) - 
    /// </summary>
    public class EHC_E24Map :
        HL7V26LayoutMap<EHC_E24>
    {
        public EHC_E24Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segment(x => x.ERR, 4);
            Segment(x => x.IVC, 5, x => x.Required = true);
            Layout(x => x.PslItemInfo, 6, x => x.Required = true);
        }
    }
}