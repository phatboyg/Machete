// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRI_I12 (MessageMap) - 
    /// </summary>
    public class RRI_I12Map :
        HL7LayoutMap<RRI_I12>
    {
        public RRI_I12Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3);
            Segment(x => x.RF1, 4);
            Layout(x => x.AuthorizationContact, 5);
            Layout(x => x.ProviderContact, 6, x => x.Required = true);
            Segment(x => x.PID, 7, x => x.Required = true);
            Segment(x => x.ACC, 8);
            Segment(x => x.DG1, 9);
            Segment(x => x.DRG, 10);
            Segment(x => x.AL1, 11);
            Layout(x => x.Procedure, 12);
            Layout(x => x.Observation, 13);
            Layout(x => x.PatientVisit, 14);
            Segment(x => x.NTE, 15);
        }
    }
}