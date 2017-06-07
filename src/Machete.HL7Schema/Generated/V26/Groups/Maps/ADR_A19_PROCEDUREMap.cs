// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADR_A19_PROCEDURE (GroupMap) - 
    /// </summary>
    public class ADR_A19_PROCEDUREMap :
        HL7V26LayoutMap<ADR_A19_PROCEDURE>
    {
        public ADR_A19_PROCEDUREMap()
        {
            Segment(x => x.PR1, 0, x => x.Required = true);
            Segment(x => x.ROL, 1);
        }
    }
}