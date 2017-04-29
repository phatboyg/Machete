// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSU_C09 (MessageMap) - 
    /// </summary>
    public class CSU_C09Map :
        HL7TemplateMap<CSU_C09>
    {
        public CSU_C09Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Groups(x => x.Patient, 3, x => x.Required = true);
        }
    }
}