// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORG_O20_SPECIMEN (GroupMap) - 
    /// </summary>
    public class ORG_O20_SPECIMENMap :
        HL7LayoutMap<ORG_O20_SPECIMEN>
    {
        public ORG_O20_SPECIMENMap()
        {
            Segment(x => x.SPM, 0, x => x.Required = true);
            Segment(x => x.SAC, 1);
        }
    }
}