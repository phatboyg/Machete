// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMP_O09_ORDER (GroupMap) - 
    /// </summary>
    public class OMP_O09_ORDERMap :
        HL7TemplateMap<OMP_O09_ORDER>
    {
        public OMP_O09_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Segment(x => x.RXO, 2, x => x.Required = true);
            Segments(x => x.NTE, 3);
            Segments(x => x.RXR, 4, x => x.Required = true);
            Groups(x => x.Component, 5);
            Groups(x => x.Observation, 6);
            Segments(x => x.FT1, 7);
            Segment(x => x.BLG, 8);
        }
    }
}