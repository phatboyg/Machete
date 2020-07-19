// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E13_REQUEST (GroupMap) - 
    /// </summary>
    public class EHC_E13_REQUESTMap :
        HL7V26LayoutMap<EHC_E13_REQUEST>
    {
        public EHC_E13_REQUESTMap()
        {
            Segment(x => x.CTD, 0);
            Segment(x => x.OBR, 1, x => x.Required = true);
            Segment(x => x.NTE, 2);
            Layout(x => x.Response, 3, x => x.Required = true);
        }
    }
}