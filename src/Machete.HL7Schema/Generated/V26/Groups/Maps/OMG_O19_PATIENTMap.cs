// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMG_O19_PATIENT (GroupMap) - 
    /// </summary>
    public class OMG_O19_PATIENTMap :
        HL7TemplateMap<OMG_O19_PATIENT>
    {
        public OMG_O19_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PD1, 1);
            Map(x => x.NTE, 2);
            Map(x => x.NK1, 3);
            Map(x => x.PatientVisit, 4);
            Map(x => x.Insurance, 5);
            Map(x => x.GT1, 6);
            Map(x => x.AL1, 7);
        }
    }
}