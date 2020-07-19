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
        HL7V26LayoutMap<OMP_O09_ORDER>
    {
        public OMP_O09_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Segment(x => x.RXO, 2, x => x.Required = true);
            Segment(x => x.NTE, 3);
            Segment(x => x.RXR, 4, x => x.Required = true);
            Layout(x => x.Component, 5);
            Layout(x => x.Observation, 6);
            Segment(x => x.FT1, 7);
            Segment(x => x.BLG, 8);
        }
    }
}