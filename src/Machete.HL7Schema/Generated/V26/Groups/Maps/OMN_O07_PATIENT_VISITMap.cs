// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMN_O07_PATIENT_VISIT (GroupMap) - 
    /// </summary>
    public class OMN_O07_PATIENT_VISITMap :
        HL7TemplateMap<OMN_O07_PATIENT_VISIT>
    {
        public OMN_O07_PATIENT_VISITMap()
        {
            Segment(x => x.PV1, 0, x => x.Required = true);
            Segment(x => x.PV2, 1);
        }
    }
}