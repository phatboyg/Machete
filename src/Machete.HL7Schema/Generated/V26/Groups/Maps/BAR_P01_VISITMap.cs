// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BAR_P01_VISIT (GroupMap) - 
    /// </summary>
    public class BAR_P01_VISITMap :
        HL7V26LayoutMap<BAR_P01_VISIT>
    {
        public BAR_P01_VISITMap()
        {
            Segment(x => x.PV1, 0);
            Segment(x => x.PV2, 1);
            Segment(x => x.ROL, 2);
            Segment(x => x.DB1, 3);
            Segment(x => x.OBX, 4);
            Segment(x => x.AL1, 5);
            Segment(x => x.DG1, 6);
            Segment(x => x.DRG, 7);
            Layout(x => x.Procedure, 8);
            Segment(x => x.GT1, 9);
            Segment(x => x.NK1, 10);
            Layout(x => x.Insurance, 11);
            Segment(x => x.ACC, 12);
            Segment(x => x.UB1, 13);
            Segment(x => x.UB2, 14);
        }
    }
}