// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O35_PATIENT_PRIOR (GroupMap) - 
    /// </summary>
    public class OML_O35_PATIENT_PRIORMap :
        HL7TemplateMap<OML_O35_PATIENT_PRIOR>
    {
        public OML_O35_PATIENT_PRIORMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
        }
    }
}