// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORG_O20_ORDER (GroupMap) - 
    /// </summary>
    public class ORG_O20_ORDERMap :
        HL7TemplateMap<ORG_O20_ORDER>
    {
        public ORG_O20_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.ObservationGroup, 2);
            Map(x => x.NTE, 3);
            Map(x => x.CTI, 4);
            Map(x => x.Specimen, 5);
        }
    }
}