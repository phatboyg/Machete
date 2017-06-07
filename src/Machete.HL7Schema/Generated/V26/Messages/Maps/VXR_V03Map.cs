// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXR_V03 (MessageMap) - 
    /// </summary>
    public class VXR_V03Map :
        HL7V26LayoutMap<VXR_V03>
    {
        public VXR_V03Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segment(x => x.SFT, 2);
            Segment(x => x.UAC, 3);
            Segment(x => x.QRD, 4, x => x.Required = true);
            Segment(x => x.QRF, 5);
            Segment(x => x.PID, 6, x => x.Required = true);
            Segment(x => x.PD1, 7);
            Segment(x => x.NK1, 8);
            Layout(x => x.PatientVisit, 9);
            Segment(x => x.GT1, 10);
            Layout(x => x.Insurance, 11);
            Layout(x => x.Order, 12);
        }
    }
}