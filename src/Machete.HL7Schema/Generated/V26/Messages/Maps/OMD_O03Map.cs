// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMD_O03 (MessageMap) - 
    /// </summary>
    public class OMD_O03Map :
        HL7TemplateMap<OMD_O03>
    {
        public OMD_O03Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segments(x => x.NTE, 3);
            Group(x => x.Patient, 4);
            Groups(x => x.OrderDiet, 5, x => x.Required = true);
            Groups(x => x.OrderTray, 6);
        }
    }
}