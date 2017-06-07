// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E01_PATIENT_INFO (GroupMap) - 
    /// </summary>
    public class EHC_E01_PATIENT_INFOMap :
        HL7V26LayoutMap<EHC_E01_PATIENT_INFO>
    {
        public EHC_E01_PATIENT_INFOMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PV1, 1);
            Segment(x => x.PV2, 2);
            Segment(x => x.ACC, 3);
            Layout(x => x.Insurance, 4, x => x.Required = true);
            Layout(x => x.Diagnosis, 5);
            Segment(x => x.OBX, 6);
        }
    }
}