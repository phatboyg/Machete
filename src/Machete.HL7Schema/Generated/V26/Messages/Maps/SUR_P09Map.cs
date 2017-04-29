// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SUR_P09 (MessageMap) - 
    /// </summary>
    public class SUR_P09Map :
        HL7TemplateMap<SUR_P09>
    {
        public SUR_P09Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Groups(x => x.Facility, 1, x => x.Required = true);
        }
    }
}