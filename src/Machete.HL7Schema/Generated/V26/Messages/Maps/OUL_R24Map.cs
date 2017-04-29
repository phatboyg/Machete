// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R24 (MessageMap) - 
    /// </summary>
    public class OUL_R24Map :
        HL7TemplateMap<OUL_R24>
    {
        public OUL_R24Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.NTE, 3);
            Group(x => x.Patient, 4);
            Segments(x => x.NK1, 5);
            Groups(x => x.Order, 6, x => x.Required = true);
            Segment(x => x.DSC, 7);
        }
    }
}