// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CRM_C01 (MessageMap) - 
    /// </summary>
    public class CRM_C01Map :
        HL7V26LayoutMap<CRM_C01>
    {
        public CRM_C01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Layout(x => x.Patient, 3, x => x.Required = true);
        }
    }
}