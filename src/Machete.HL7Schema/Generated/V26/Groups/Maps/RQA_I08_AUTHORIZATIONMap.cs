// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQA_I08_AUTHORIZATION (GroupMap) - 
    /// </summary>
    public class RQA_I08_AUTHORIZATIONMap :
        HL7TemplateMap<RQA_I08_AUTHORIZATION>
    {
        public RQA_I08_AUTHORIZATIONMap()
        {
            Map(x => x.AUT, 0, x => x.Required = true);
            Map(x => x.CTD, 1);
        }
    }
}