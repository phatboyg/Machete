// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXQ_V01 (MessageMap) - 
    /// </summary>
    public class VXQ_V01Map :
        HL7TemplateMap<VXQ_V01>
    {
        public VXQ_V01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.QRD, 3, x => x.Required = true);
            Segment(x => x.QRF, 4);
        }
    }
}