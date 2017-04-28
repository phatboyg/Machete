// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORU_R01_ORDER_OBSERVATION (GroupMap) - 
    /// </summary>
    public class ORU_R01_ORDER_OBSERVATIONMap :
        HL7TemplateMap<ORU_R01_ORDER_OBSERVATION>
    {
        public ORU_R01_ORDER_OBSERVATIONMap()
        {
            Map(x => x.ORC, 0);
            Map(x => x.OBR, 1, x => x.Required = true);
            Map(x => x.NTE, 2);
            Map(x => x.ROL, 3);
            Map(x => x.TimingQty, 4);
            Map(x => x.CTD, 5);
            Map(x => x.Observation, 6);
            Map(x => x.FT1, 7);
            Map(x => x.CTI, 8);
            Map(x => x.Specimen, 9);
        }
    }
}