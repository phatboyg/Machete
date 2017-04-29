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
            Segments(x => x.NK1, 0, x => x.Required = true);
            Group(x => x.Patient, 1);
            Groups(x => x.Specimen, 2, x => x.Required = true);
            Group(x => x.PriorResult, 3);
            Segments(x => x.FT1, 4);
            Segments(x => x.CTI, 5);
            Segment(x => x.BLG, 6);
        }
    }
}