// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPU_R25_ACCESSION_DETAIL (GroupMap) - 
    /// </summary>
    public class OPU_R25_ACCESSION_DETAILMap :
        HL7TemplateMap<OPU_R25_ACCESSION_DETAIL>
    {
        public OPU_R25_ACCESSION_DETAILMap()
        {
            Segments(x => x.NK1, 0, x => x.Required = true);
            Group(x => x.Patient, 1);
            Groups(x => x.Specimen, 2, x => x.Required = true);
        }
    }
}