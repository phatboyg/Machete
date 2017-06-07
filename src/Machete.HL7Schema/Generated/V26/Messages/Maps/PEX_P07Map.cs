// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEX_P07 (MessageMap) - 
    /// </summary>
    public class PEX_P07Map :
        HL7V26LayoutMap<PEX_P07>
    {
        public PEX_P07Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PD1, 5);
            Segment(x => x.NTE, 6);
            Layout(x => x.Visit, 7);
            Layout(x => x.Experience, 8, x => x.Required = true);
        }
    }
}