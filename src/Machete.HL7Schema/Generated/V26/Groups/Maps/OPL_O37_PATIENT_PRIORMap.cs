// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_PATIENT_PRIOR (GroupMap) - 
    /// </summary>
    public class OPL_O37_PATIENT_PRIORMap :
        HL7TemplateMap<OPL_O37_PATIENT_PRIOR>
    {
        public OPL_O37_PATIENT_PRIORMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PD1, 1);
        }
    }
}