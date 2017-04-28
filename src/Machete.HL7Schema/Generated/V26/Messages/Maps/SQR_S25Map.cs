// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQR_S25 (MessageMap) - 
    /// </summary>
    public class SQR_S25Map :
        HL7TemplateMap<SQR_S25>
    {
        public SQR_S25Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.MSA, 1, x => x.Required = true);
            Map(x => x.ERR, 2);
            Map(x => x.QAK, 3, x => x.Required = true);
            Map(x => x.Schedule, 4);
            Map(x => x.DSC, 5);
        }
    }
}