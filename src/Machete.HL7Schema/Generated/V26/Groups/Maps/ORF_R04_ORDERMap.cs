// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORF_R04_ORDER (GroupMap) - 
    /// </summary>
    public class ORF_R04_ORDERMap :
        HL7LayoutMap<ORF_R04_ORDER>
    {
        public ORF_R04_ORDERMap()
        {
            Segment(x => x.ORC, 0);
            Segment(x => x.OBR, 1, x => x.Required = true);
            Segment(x => x.NTE, 2);
            Segment(x => x.ROL, 3);
            Layout(x => x.TimingQty, 4);
            Segment(x => x.CTD, 5);
            Layout(x => x.Observation, 6, x => x.Required = true);
            Segment(x => x.CTI, 7);
        }
    }
}