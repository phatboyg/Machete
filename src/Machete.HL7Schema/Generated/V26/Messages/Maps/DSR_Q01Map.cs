// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DSR_Q01 (MessageMap) - 
    /// </summary>
    public class DSR_Q01Map :
        HL7TemplateMap<DSR_Q01>
    {
        public DSR_Q01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segment(x => x.ERR, 4);
            Segment(x => x.QAK, 5);
            Segment(x => x.QRD, 6, x => x.Required = true);
            Segment(x => x.QRF, 7);
            Segments(x => x.DSP, 8, x => x.Required = true);
            Segment(x => x.DSC, 9);
        }
    }
}