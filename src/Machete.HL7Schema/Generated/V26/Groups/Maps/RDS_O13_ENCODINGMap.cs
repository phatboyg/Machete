// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDS_O13_ENCODING (GroupMap) - 
    /// </summary>
    public class RDS_O13_ENCODINGMap :
        HL7V26LayoutMap<RDS_O13_ENCODING>
    {
        public RDS_O13_ENCODINGMap()
        {
            Segment(x => x.RXE, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Layout(x => x.TimingEncoded, 2, x => x.Required = true);
            Segment(x => x.RXR, 3, x => x.Required = true);
            Segment(x => x.RXC, 4);
        }
    }
}