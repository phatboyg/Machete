// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQA_I08 (MessageMap) - 
    /// </summary>
    public class RQA_I08Map :
        HL7V26LayoutMap<RQA_I08>
    {
        public RQA_I08Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.RF1, 3);
            Layout(x => x.Authorization, 4);
            Layout(x => x.Provider, 5, x => x.Required = true);
            Segment(x => x.PID, 6, x => x.Required = true);
            Segment(x => x.NK1, 7);
            Layout(x => x.GuarantorInsurance, 8);
            Segment(x => x.ACC, 9);
            Segment(x => x.DG1, 10);
            Segment(x => x.DRG, 11);
            Segment(x => x.AL1, 12);
            Layout(x => x.Procedure, 13);
            Layout(x => x.Observation, 14);
            Layout(x => x.Visit, 15);
            Segment(x => x.NTE, 16);
        }
    }
}