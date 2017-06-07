// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORL_O34_SPECIMEN (GroupMap) - 
    /// </summary>
    public class ORL_O34_SPECIMENMap :
        HL7V26LayoutMap<ORL_O34_SPECIMEN>
    {
        public ORL_O34_SPECIMENMap()
        {
            Segment(x => x.SPM, 0, x => x.Required = true);
            Segment(x => x.OBX, 1);
            Segment(x => x.SAC, 2);
            Layout(x => x.Order, 3);
        }
    }
}