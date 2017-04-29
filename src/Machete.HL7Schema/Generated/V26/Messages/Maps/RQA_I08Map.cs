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
        HL7TemplateMap<RQA_I08>
    {
        public RQA_I08Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.RF1, 3);
            Group(x => x.Authorization, 4);
            Groups(x => x.Provider, 5, x => x.Required = true);
            Segment(x => x.PID, 6, x => x.Required = true);
            Segments(x => x.NK1, 7);
            Group(x => x.GuarantorInsurance, 8);
            Segment(x => x.ACC, 9);
            Segments(x => x.DG1, 10);
            Segments(x => x.DRG, 11);
            Segments(x => x.AL1, 12);
            Groups(x => x.Procedure, 13);
            Groups(x => x.Observation, 14);
            Group(x => x.Visit, 15);
            Segments(x => x.NTE, 16);
        }
    }
}