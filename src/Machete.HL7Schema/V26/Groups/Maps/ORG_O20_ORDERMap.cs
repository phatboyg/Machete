// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORG_O20_ORDER (GroupMap) - 
    /// </summary>
    public class ORG_O20_ORDERMap :
        HL7V26LayoutMap<ORG_O20_ORDER>
    {
        public ORG_O20_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Layout(x => x.ObservationGroup, 2);
            Segment(x => x.NTE, 3);
            Segment(x => x.CTI, 4);
            Layout(x => x.Specimen, 5);
        }
    }
}