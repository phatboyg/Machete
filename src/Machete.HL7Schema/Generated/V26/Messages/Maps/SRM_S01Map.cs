// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRM_S01 (MessageMap) - 
    /// </summary>
    public class SRM_S01Map :
        HL7TemplateMap<SRM_S01>
    {
        public SRM_S01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.ARQ, 1, x => x.Required = true);
            Segment(x => x.APR, 2);
            Segments(x => x.NTE, 3);
            Groups(x => x.Patient, 4);
            Groups(x => x.Resources, 5, x => x.Required = true);
        }
    }
}