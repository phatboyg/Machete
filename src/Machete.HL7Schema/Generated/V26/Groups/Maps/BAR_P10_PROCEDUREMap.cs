// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BAR_P10_PROCEDURE (GroupMap) - 
    /// </summary>
    public class BAR_P10_PROCEDUREMap :
        HL7LayoutMap<BAR_P10_PROCEDURE>
    {
        public BAR_P10_PROCEDUREMap()
        {
            Segment(x => x.PR1, 0, x => x.Required = true);
            Segment(x => x.GP2, 1);
        }
    }
}