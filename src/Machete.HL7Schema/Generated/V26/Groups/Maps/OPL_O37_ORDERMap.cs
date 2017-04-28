// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_ORDER (GroupMap) - 
    /// </summary>
    public class OPL_O37_ORDERMap :
        HL7TemplateMap<OPL_O37_ORDER>
    {
        public OPL_O37_ORDERMap()
        {
            Map(x => x.NK1, 0, x => x.Required = true);
            Map(x => x.Patient, 1);
            Map(x => x.Specimen, 2, x => x.Required = true);
            Map(x => x.PriorResult, 3);
            Map(x => x.FT1, 4);
            Map(x => x.CTI, 5);
            Map(x => x.BLG, 6);
        }
    }
}