// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGR_RGR (MessageMap) - 
    /// </summary>
    public class RGR_RGRMap :
        HL7V26LayoutMap<RGR_RGR>
    {
        public RGR_RGRMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segment(x => x.ERR, 2);
            Segment(x => x.SFT, 3);
            Segment(x => x.UAC, 4);
            Layout(x => x.Definition, 5, x => x.Required = true);
            Segment(x => x.DSC, 6);
        }
    }
}