// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXU_V04 (MessageMap) - 
    /// </summary>
    public class VXU_V04Map :
        HL7TemplateMap<VXU_V04>
    {
        public VXU_V04Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.PID, 3, x => x.Required = true);
            Map(x => x.PD1, 4);
            Map(x => x.NK1, 5);
            Map(x => x.Patient, 6);
            Map(x => x.GT1, 7);
            Map(x => x.Insurance, 8);
            Map(x => x.Order, 9);
        }
    }
}