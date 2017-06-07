// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORL_O22_SPECIMEN (GroupMap) - 
    /// </summary>
    public class ORL_O22_SPECIMENMap :
        HL7V26LayoutMap<ORL_O22_SPECIMEN>
    {
        public ORL_O22_SPECIMENMap()
        {
            Segment(x => x.SPM, 0, x => x.Required = true);
            Segment(x => x.SAC, 1);
        }
    }
}