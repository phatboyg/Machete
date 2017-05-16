// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// REF_I12 (MessageMap) - 
    /// </summary>
    public class REF_I12Map :
        HL7LayoutMap<REF_I12>
    {
        public REF_I12Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.RF1, 3);
            Layout(x => x.AuthorizationContact, 4);
            Layout(x => x.ProviderContact, 5, x => x.Required = true);
            Segment(x => x.PID, 6, x => x.Required = true);
            Segment(x => x.NK1, 7);
            Segment(x => x.GT1, 8);
            Layout(x => x.Insurance, 9);
            Segment(x => x.ACC, 10);
            Segment(x => x.DG1, 11);
            Segment(x => x.DRG, 12);
            Segment(x => x.AL1, 13);
            Layout(x => x.Procedure, 14);
            Layout(x => x.Observation, 15);
            Layout(x => x.PatientVisit, 16);
            Segment(x => x.NTE, 17);
        }
    }
}