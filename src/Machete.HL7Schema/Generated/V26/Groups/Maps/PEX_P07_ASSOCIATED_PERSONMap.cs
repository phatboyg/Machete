// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEX_P07_ASSOCIATED_PERSON (GroupMap) - 
    /// </summary>
    public class PEX_P07_ASSOCIATED_PERSONMap :
        HL7V26LayoutMap<PEX_P07_ASSOCIATED_PERSON>
    {
        public PEX_P07_ASSOCIATED_PERSONMap()
        {
            Segment(x => x.NK1, 0, x => x.Required = true);
            Layout(x => x.AssociatedRxOrder, 1);
            Layout(x => x.AssociatedRxAdmin, 2);
            Segment(x => x.PRB, 3);
            Segment(x => x.OBX, 4);
        }
    }
}