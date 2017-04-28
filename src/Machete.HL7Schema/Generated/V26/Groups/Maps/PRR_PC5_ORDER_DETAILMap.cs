// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRR_PC5_ORDER_DETAIL (GroupMap) - 
    /// </summary>
    public class PRR_PC5_ORDER_DETAILMap :
        HL7TemplateMap<PRR_PC5_ORDER_DETAIL>
    {
        public PRR_PC5_ORDER_DETAILMap()
        {
            Map(x => x.OBR, 0, x => x.Required = true);
            Map(x => x.Hxx, 1, x => x.Required = true);
            Map(x => x.NTE, 2);
            Map(x => x.VAR, 3);
            Map(x => x.OrderObservation, 4);
        }
    }
}