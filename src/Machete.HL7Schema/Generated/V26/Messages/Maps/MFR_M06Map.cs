// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFR_M06 (MessageMap) - 
    /// </summary>
    public class MFR_M06Map :
        HL7TemplateMap<MFR_M06>
    {
        public MFR_M06Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.MSA, 2, x => x.Required = true);
            Segments(x => x.ERR, 3);
            Segment(x => x.QAK, 4);
            Segment(x => x.QRD, 5, x => x.Required = true);
            Segment(x => x.QRF, 6);
            Segment(x => x.MFI, 7, x => x.Required = true);
            Groups(x => x.MfQuery, 8, x => x.Required = true);
            Segment(x => x.DSC, 9);
        }
    }
}