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
        HL7TemplateMap<PEX_P07_ASSOCIATED_PERSON>
    {
        public PEX_P07_ASSOCIATED_PERSONMap()
        {
            Map(x => x.NK1, 0, x => x.Required = true);
            Map(x => x.AssociatedRxOrder, 1);
            Map(x => x.AssociatedRxAdmin, 2);
            Map(x => x.PRB, 3);
            Map(x => x.OBX, 4);
        }
    }
}