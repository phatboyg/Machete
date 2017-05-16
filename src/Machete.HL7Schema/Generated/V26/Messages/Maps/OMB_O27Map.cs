// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMB_O27 (MessageMap) - 
    /// </summary>
    public class OMB_O27Map :
        HL7LayoutMap<OMB_O27>
    {
        public OMB_O27Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.NTE, 3);
            Layout(x => x.Patient, 4);
            Layout(x => x.Order, 5, x => x.Required = true);
        }
    }
}