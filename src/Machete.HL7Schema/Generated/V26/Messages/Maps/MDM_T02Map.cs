// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MDM_T02 (MessageMap) - 
    /// </summary>
    public class MDM_T02Map :
        HL7TemplateMap<MDM_T02>
    {
        public MDM_T02Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PV1, 5, x => x.Required = true);
            Groups(x => x.CommonOrder, 6);
            Segment(x => x.TXA, 7, x => x.Required = true);
            Groups(x => x.Observation, 8, x => x.Required = true);
        }
    }
}