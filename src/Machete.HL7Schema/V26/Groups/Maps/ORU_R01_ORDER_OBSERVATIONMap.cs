// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORU_R01_ORDER_OBSERVATION (GroupMap) - 
    /// </summary>
    public class ORU_R01_ORDER_OBSERVATIONMap :
        HL7V26LayoutMap<ORU_R01_ORDER_OBSERVATION>
    {
        public ORU_R01_ORDER_OBSERVATIONMap()
        {
            Segment(x => x.ORC, 0);
            Segment(x => x.OBR, 1, x => x.Required = true);
            Segment(x => x.NTE, 2);
            Segment(x => x.ROL, 3);
            Layout(x => x.TimingQty, 4);
            Segment(x => x.CTD, 5);
            Layout(x => x.Observation, 6);
            Segment(x => x.FT1, 7);
            Segment(x => x.CTI, 8);
            Layout(x => x.Specimen, 9);
        }
    }
}