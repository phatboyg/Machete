// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_PATIENT_VISIT_PRIOR (GroupMap) - 
    /// </summary>
    public class OPL_O37_PATIENT_VISIT_PRIORMap :
        HL7TemplateMap<OPL_O37_PATIENT_VISIT_PRIOR>
    {
        public OPL_O37_PATIENT_VISIT_PRIORMap()
        {
            Map(x => x.PV1, 0, x => x.Required = true);
            Map(x => x.PV2, 1);
        }
    }
}