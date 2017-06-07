// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORU_R01 (MessageMap) - 
    /// </summary>
    public class ORU_R01Map :
        HL7V26LayoutMap<ORU_R01>
    {
        public ORU_R01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Layout(x => x.PatientResult, 3, x => x.Required = true);
            Segment(x => x.DSC, 4);
        }
    }
}