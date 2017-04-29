// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORU_R01_PATIENT_RESULT (GroupMap) - 
    /// </summary>
    public class ORU_R01_PATIENT_RESULTMap :
        HL7TemplateMap<ORU_R01_PATIENT_RESULT>
    {
        public ORU_R01_PATIENT_RESULTMap()
        {
            Group(x => x.Patient, 0);
            Groups(x => x.OrderObservation, 1, x => x.Required = true);
        }
    }
}