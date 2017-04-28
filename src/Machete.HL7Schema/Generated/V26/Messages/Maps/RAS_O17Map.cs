// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAS_O17 (MessageMap) - 
    /// </summary>
    public class RAS_O17Map :
        HL7TemplateMap<RAS_O17>
    {
        public RAS_O17Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.NTE, 3);
            Map(x => x.Patient, 4);
            Map(x => x.Order, 5, x => x.Required = true);
        }
    }
}