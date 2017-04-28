// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QBP_Q21 (MessageMap) - 
    /// </summary>
    public class QBP_Q21Map :
        HL7TemplateMap<QBP_Q21>
    {
        public QBP_Q21Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.QPD, 3, x => x.Required = true);
            Map(x => x.RCP, 4, x => x.Required = true);
            Map(x => x.DSC, 5);
        }
    }
}