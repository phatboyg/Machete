// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37 (MessageMap) - 
    /// </summary>
    public class OPL_O37Map :
        HL7TemplateMap<OPL_O37>
    {
        public OPL_O37Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segments(x => x.NTE, 3);
            Segments(x => x.ROL, 4, x => x.Required = true);
            Group(x => x.Guarantor, 5);
            Groups(x => x.Order, 6, x => x.Required = true);
        }
    }
}