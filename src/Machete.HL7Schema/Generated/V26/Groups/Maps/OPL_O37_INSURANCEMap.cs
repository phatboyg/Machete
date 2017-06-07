// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_INSURANCE (GroupMap) - 
    /// </summary>
    public class OPL_O37_INSURANCEMap :
        HL7V26LayoutMap<OPL_O37_INSURANCE>
    {
        public OPL_O37_INSURANCEMap()
        {
            Segment(x => x.IN1, 0, x => x.Required = true);
            Segment(x => x.IN2, 1);
            Segment(x => x.IN3, 2);
        }
    }
}