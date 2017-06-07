// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEX_P07_PEX_CAUSE (GroupMap) - 
    /// </summary>
    public class PEX_P07_PEX_CAUSEMap :
        HL7V26LayoutMap<PEX_P07_PEX_CAUSE>
    {
        public PEX_P07_PEX_CAUSEMap()
        {
            Segment(x => x.PCR, 0, x => x.Required = true);
            Layout(x => x.RxOrder, 1);
            Layout(x => x.RxAdministration, 2);
            Segment(x => x.PRB, 3);
            Segment(x => x.OBX, 4);
            Segment(x => x.NTE, 5);
            Layout(x => x.AssociatedPerson, 6);
            Layout(x => x.Study, 7);
        }
    }
}