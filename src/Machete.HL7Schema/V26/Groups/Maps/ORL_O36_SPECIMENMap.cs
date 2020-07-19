// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORL_O36_SPECIMEN (GroupMap) - 
    /// </summary>
    public class ORL_O36_SPECIMENMap :
        HL7V26LayoutMap<ORL_O36_SPECIMEN>
    {
        public ORL_O36_SPECIMENMap()
        {
            Segment(x => x.SPM, 0, x => x.Required = true);
            Segment(x => x.OBX, 1);
            Segment(x => x.NTE, 2);
            Layout(x => x.SpecimenContainer, 3, x => x.Required = true);
        }
    }
}