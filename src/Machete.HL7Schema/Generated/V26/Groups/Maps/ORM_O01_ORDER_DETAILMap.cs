// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORM_O01_ORDER_DETAIL (GroupMap) - 
    /// </summary>
    public class ORM_O01_ORDER_DETAILMap :
        HL7TemplateMap<ORM_O01_ORDER_DETAIL>
    {
        public ORM_O01_ORDER_DETAILMap()
        {
            Map(x => x.OBR, 0, x => x.Required = true);
            Map(x => x.RQD, 1, x => x.Required = true);
            Map(x => x.RQ1, 2, x => x.Required = true);
            Map(x => x.RXO, 3, x => x.Required = true);
            Map(x => x.ODS, 4, x => x.Required = true);
            Map(x => x.ODT, 5, x => x.Required = true);
            Map(x => x.NTE, 6);
            Map(x => x.CTD, 7);
            Map(x => x.DG1, 8);
            Map(x => x.Observation, 9);
        }
    }
}