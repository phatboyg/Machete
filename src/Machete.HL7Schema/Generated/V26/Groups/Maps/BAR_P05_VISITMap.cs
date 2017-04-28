// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BAR_P05_VISIT (GroupMap) - 
    /// </summary>
    public class BAR_P05_VISITMap :
        HL7TemplateMap<BAR_P05_VISIT>
    {
        public BAR_P05_VISITMap()
        {
            Map(x => x.PV1, 0);
            Map(x => x.PV2, 1);
            Map(x => x.ROL, 2);
            Map(x => x.DB1, 3);
            Map(x => x.OBX, 4);
            Map(x => x.AL1, 5);
            Map(x => x.DG1, 6);
            Map(x => x.DRG, 7);
            Map(x => x.Procedure, 8);
            Map(x => x.GT1, 9);
            Map(x => x.NK1, 10);
            Map(x => x.Insurance, 11);
            Map(x => x.ACC, 12);
            Map(x => x.UB1, 13);
            Map(x => x.UB2, 14);
            Map(x => x.ABS, 15);
            Map(x => x.BLC, 16);
            Map(x => x.RMI, 17);
        }
    }
}