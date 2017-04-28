// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRR_PC5_PATIENT (GroupMap) - 
    /// </summary>
    public class PRR_PC5_PATIENTMap :
        HL7TemplateMap<PRR_PC5_PATIENT>
    {
        public PRR_PC5_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PatientVisit, 1);
            Map(x => x.Problem, 2, x => x.Required = true);
        }
    }
}