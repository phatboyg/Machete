// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O35_ORDER (GroupMap) - 
    /// </summary>
    public class OML_O35_ORDERMap :
        HL7V26LayoutMap<OML_O35_ORDER>
    {
        public OML_O35_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Layout(x => x.ObservationRequest, 2);
            Segment(x => x.FT1, 3);
            Segment(x => x.CTI, 4);
            Segment(x => x.BLG, 5);
        }
    }
}