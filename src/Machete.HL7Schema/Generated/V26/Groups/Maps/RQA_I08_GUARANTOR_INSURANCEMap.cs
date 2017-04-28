// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQA_I08_GUARANTOR_INSURANCE (GroupMap) - 
    /// </summary>
    public class RQA_I08_GUARANTOR_INSURANCEMap :
        HL7TemplateMap<RQA_I08_GUARANTOR_INSURANCE>
    {
        public RQA_I08_GUARANTOR_INSURANCEMap()
        {
            Map(x => x.GT1, 0);
            Map(x => x.Insurance, 1, x => x.Required = true);
        }
    }
}