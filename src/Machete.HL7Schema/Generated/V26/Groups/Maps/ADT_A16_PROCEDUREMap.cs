// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A16_PROCEDURE (GroupMap) - 
    /// </summary>
    public class ADT_A16_PROCEDUREMap :
        HL7TemplateMap<ADT_A16_PROCEDURE>
    {
        public ADT_A16_PROCEDUREMap()
        {
            Map(x => x.PR1, 0, x => x.Required = true);
            Map(x => x.ROL, 1);
        }
    }
}