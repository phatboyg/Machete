// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RCL_I06 (MessageMap) - 
    /// </summary>
    public class RCL_I06Map :
        HL7V26LayoutMap<RCL_I06>
    {
        public RCL_I06Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segment(x => x.QRD, 4, x => x.Required = true);
            Segment(x => x.QRF, 5);
            Layout(x => x.Provider, 6, x => x.Required = true);
            Segment(x => x.PID, 7, x => x.Required = true);
            Segment(x => x.DG1, 8);
            Segment(x => x.DRG, 9);
            Segment(x => x.AL1, 10);
            Segment(x => x.NTE, 11);
            Segment(x => x.DSP, 12);
            Segment(x => x.DSC, 13);
        }
    }
}