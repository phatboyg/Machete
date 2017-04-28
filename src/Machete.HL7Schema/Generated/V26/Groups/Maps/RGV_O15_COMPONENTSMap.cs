// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGV_O15_COMPONENTS (GroupMap) - 
    /// </summary>
    public class RGV_O15_COMPONENTSMap :
        HL7TemplateMap<RGV_O15_COMPONENTS>
    {
        public RGV_O15_COMPONENTSMap()
        {
            Map(x => x.RXC, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}