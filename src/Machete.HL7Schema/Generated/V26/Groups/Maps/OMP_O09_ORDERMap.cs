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
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.RXO, 2, x => x.Required = true);
            Map(x => x.NTE, 3);
            Map(x => x.RXR, 4, x => x.Required = true);
            Map(x => x.Component, 5);
            Map(x => x.Observation, 6);
            Map(x => x.FT1, 7);
            Map(x => x.BLG, 8);
        }
    }
}