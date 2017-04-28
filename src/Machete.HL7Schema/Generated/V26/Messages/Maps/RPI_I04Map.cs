// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPI_I04 (MessageMap) - 
    /// </summary>
    public class RPI_I04Map :
        HL7TemplateMap<RPI_I04>
    {
        public RPI_I04Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.Provider, 4, x => x.Required = true);
            Map(x => x.PID, 5, x => x.Required = true);
            Map(x => x.NK1, 6);
            Map(x => x.GuarantorInsurance, 7);
            Map(x => x.NTE, 8);
        }
    }
}