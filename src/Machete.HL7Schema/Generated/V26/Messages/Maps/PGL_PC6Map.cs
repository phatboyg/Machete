// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PGL_PC6 (MessageMap) - 
    /// </summary>
    public class PGL_PC6Map :
        HL7TemplateMap<PGL_PC6>
    {
        public PGL_PC6Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.PID, 3, x => x.Required = true);
            Map(x => x.PatientVisit, 4);
            Map(x => x.Goal, 5, x => x.Required = true);
        }
    }
}