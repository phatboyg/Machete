// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BAR_P10 (MessageMap) - 
    /// </summary>
    public class BAR_P10Map :
        HL7LayoutMap<BAR_P10>
    {
        public BAR_P10Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PV1, 5, x => x.Required = true);
            Segment(x => x.DG1, 6);
            Segment(x => x.GP1, 7, x => x.Required = true);
            Layout(x => x.Procedure, 8);
        }
    }
}