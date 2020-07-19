// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQM_S25 (MessageMap) - 
    /// </summary>
    public class SQM_S25Map :
        HL7V26LayoutMap<SQM_S25>
    {
        public SQM_S25Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.QRD, 1, x => x.Required = true);
            Segment(x => x.QRF, 2);
            Layout(x => x.Request, 3);
            Segment(x => x.DSC, 4);
        }
    }
}