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
        HL7TemplateMap<REF_I12>
    {
        public REF_I12Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.RF1, 3);
            Group(x => x.AuthorizationContact, 4);
            Groups(x => x.ProviderContact, 5, x => x.Required = true);
            Segment(x => x.PID, 6, x => x.Required = true);
            Segments(x => x.NK1, 7);
            Segments(x => x.GT1, 8);
            Groups(x => x.Insurance, 9);
            Segment(x => x.ACC, 10);
            Segments(x => x.DG1, 11);
            Segments(x => x.DRG, 12);
            Segments(x => x.AL1, 13);
            Groups(x => x.Procedure, 14);
            Groups(x => x.Observation, 15);
            Group(x => x.PatientVisit, 16);
            Segments(x => x.NTE, 17);
        }
    }
}