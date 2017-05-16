// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGV_O15_ENCODING (GroupMap) - 
    /// </summary>
    public class RGV_O15_ENCODINGMap :
        HL7LayoutMap<RGV_O15_ENCODING>
    {
        public RGV_O15_ENCODINGMap()
        {
            Segment(x => x.RXE, 0, x => x.Required = true);
            Layout(x => x.TimingEncoded, 1, x => x.Required = true);
            Segment(x => x.RXR, 2, x => x.Required = true);
            Segment(x => x.RXC, 3);
        }
    }
}