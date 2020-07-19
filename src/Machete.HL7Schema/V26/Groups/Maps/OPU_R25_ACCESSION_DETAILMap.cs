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
        HL7V26LayoutMap<OPU_R25_ACCESSION_DETAIL>
    {
        public OPU_R25_ACCESSION_DETAILMap()
        {
            Segment(x => x.NK1, 0, x => x.Required = true);
            Layout(x => x.Patient, 1);
            Layout(x => x.Specimen, 2, x => x.Required = true);
        }
    }
}