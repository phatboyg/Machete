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
            Map(x => x.PCR, 0, x => x.Required = true);
            Map(x => x.RxOrder, 1);
            Map(x => x.RxAdministration, 2);
            Map(x => x.PRB, 3);
            Map(x => x.OBX, 4);
            Map(x => x.NTE, 5);
            Map(x => x.AssociatedPerson, 6);
            Map(x => x.Study, 7);
        }
    }
}