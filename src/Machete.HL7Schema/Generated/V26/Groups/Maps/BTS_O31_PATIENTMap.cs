// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BTS_O31_PATIENT (GroupMap) - 
    /// </summary>
    public class BTS_O31_PATIENTMap :
        HL7TemplateMap<BTS_O31_PATIENT>
    {
        public BTS_O31_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Segments(x => x.NTE, 2);
            Group(x => x.PatientVisit, 3);
        }
    }
}