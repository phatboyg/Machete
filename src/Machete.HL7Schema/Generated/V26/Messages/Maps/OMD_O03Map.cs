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
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.NTE, 3);
            Map(x => x.Patient, 4);
            Map(x => x.OrderDiet, 5, x => x.Required = true);
            Map(x => x.OrderTray, 6);
        }
    }
}