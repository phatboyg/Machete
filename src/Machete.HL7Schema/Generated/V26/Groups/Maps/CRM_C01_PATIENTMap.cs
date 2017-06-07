// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CRM_C01_PATIENT (GroupMap) - 
    /// </summary>
    public class CRM_C01_PATIENTMap :
        HL7V26LayoutMap<CRM_C01_PATIENT>
    {
        public CRM_C01_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PV1, 1);
            Segment(x => x.CSR, 2, x => x.Required = true);
            Segment(x => x.CSP, 3);
        }
    }
}