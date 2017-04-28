// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQM_S25_SERVICE (GroupMap) - 
    /// </summary>
    public class SQM_S25_SERVICEMap :
        HL7TemplateMap<SQM_S25_SERVICE>
    {
        public SQM_S25_SERVICEMap()
        {
            Map(x => x.AIS, 0, x => x.Required = true);
            Map(x => x.APR, 1);
        }
    }
}