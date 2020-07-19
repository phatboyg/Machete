// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXU_V04 (MessageMap) - 
    /// </summary>
    public class VXU_V04Map :
        HL7V26LayoutMap<VXU_V04>
    {
        public VXU_V04Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.PID, 3, x => x.Required = true);
            Segment(x => x.PD1, 4);
            Segment(x => x.NK1, 5);
            Layout(x => x.Patient, 6);
            Segment(x => x.GT1, 7);
            Layout(x => x.Insurance, 8);
            Layout(x => x.Order, 9);
        }
    }
}