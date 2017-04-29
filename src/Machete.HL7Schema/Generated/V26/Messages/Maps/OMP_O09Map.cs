// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMP_O09 (MessageMap) - 
    /// </summary>
    public class OMP_O09Map :
        HL7TemplateMap<OMP_O09>
    {
        public OMP_O09Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segments(x => x.NTE, 3);
            Group(x => x.Patient, 4);
            Groups(x => x.Order, 5, x => x.Required = true);
        }
    }
}