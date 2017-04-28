// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PTR_PCF_PATHWAY (GroupMap) - 
    /// </summary>
    public class PTR_PCF_PATHWAYMap :
        HL7TemplateMap<PTR_PCF_PATHWAY>
    {
        public PTR_PCF_PATHWAYMap()
        {
            Map(x => x.PTH, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.VAR, 2);
            Map(x => x.PathwayRole, 3);
            Map(x => x.Problem, 4);
        }
    }
}