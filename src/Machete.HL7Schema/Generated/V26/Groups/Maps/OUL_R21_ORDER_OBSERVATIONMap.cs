// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R21_ORDER_OBSERVATION (GroupMap) - 
    /// </summary>
    public class OUL_R21_ORDER_OBSERVATIONMap :
        HL7TemplateMap<OUL_R21_ORDER_OBSERVATION>
    {
        public OUL_R21_ORDER_OBSERVATIONMap()
        {
            Map(x => x.Container, 0);
            Map(x => x.ORC, 1);
            Map(x => x.OBR, 2, x => x.Required = true);
            Map(x => x.NTE, 3);
            Map(x => x.TimingQty, 4);
            Map(x => x.Observation, 5, x => x.Required = true);
            Map(x => x.CTI, 6);
        }
    }
}