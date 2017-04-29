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
        HL7TemplateMap<PEX_P07_PEX_CAUSE>
    {
        public PEX_P07_PEX_CAUSEMap()
        {
            Segment(x => x.PCR, 0, x => x.Required = true);
            Group(x => x.RxOrder, 1);
            Groups(x => x.RxAdministration, 2);
            Segments(x => x.PRB, 3);
            Segments(x => x.OBX, 4);
            Segments(x => x.NTE, 5);
            Group(x => x.AssociatedPerson, 6);
            Groups(x => x.Study, 7);
        }
    }
}