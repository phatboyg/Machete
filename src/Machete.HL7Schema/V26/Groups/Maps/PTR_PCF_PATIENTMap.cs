// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PTR_PCF_PATIENT (GroupMap) - 
    /// </summary>
    public class PTR_PCF_PATIENTMap :
        HL7V26LayoutMap<PTR_PCF_PATIENT>
    {
        public PTR_PCF_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Layout(x => x.PatientVisit, 1);
            Layout(x => x.Pathway, 2, x => x.Required = true);
        }
    }
}