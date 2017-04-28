// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORN_O08_ORDER (GroupMap) - 
    /// </summary>
    public class ORN_O08_ORDERMap :
        HL7TemplateMap<ORN_O08_ORDER>
    {
        public ORN_O08_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.RQD, 2, x => x.Required = true);
            Map(x => x.RQ1, 3);
            Map(x => x.NTE, 4);
        }
    }
}