// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O21_ORDER (GroupMap) - 
    /// </summary>
    public class OML_O21_ORDERMap :
        HL7TemplateMap<OML_O21_ORDER>
    {
        public OML_O21_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.ObservationRequest, 2);
            Map(x => x.FT1, 3);
            Map(x => x.CTI, 4);
            Map(x => x.BLG, 5);
        }
    }
}