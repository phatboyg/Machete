// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMS_O05_ORDER (GroupMap) - 
    /// </summary>
    public class OMS_O05_ORDERMap :
        HL7TemplateMap<OMS_O05_ORDER>
    {
        public OMS_O05_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.RQD, 2, x => x.Required = true);
            Map(x => x.RQ1, 3);
            Map(x => x.NTE, 4);
            Map(x => x.Observation, 5);
            Map(x => x.BLG, 6);
        }
    }
}