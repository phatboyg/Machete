// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQM_S25 (MessageMap) - 
    /// </summary>
    public class SQM_S25Map :
        HL7TemplateMap<SQM_S25>
    {
        public SQM_S25Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.QRD, 1, x => x.Required = true);
            Map(x => x.QRF, 2);
            Map(x => x.Request, 3);
            Map(x => x.DSC, 4);
        }
    }
}