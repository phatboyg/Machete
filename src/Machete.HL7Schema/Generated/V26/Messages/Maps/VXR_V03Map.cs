// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXR_V03 (MessageMap) - 
    /// </summary>
    public class VXR_V03Map :
        HL7TemplateMap<VXR_V03>
    {
        public VXR_V03Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.MSA, 1, x => x.Required = true);
            Map(x => x.SFT, 2);
            Map(x => x.UAC, 3);
            Map(x => x.QRD, 4, x => x.Required = true);
            Map(x => x.QRF, 5);
            Map(x => x.PID, 6, x => x.Required = true);
            Map(x => x.PD1, 7);
            Map(x => x.NK1, 8);
            Map(x => x.PatientVisit, 9);
            Map(x => x.GT1, 10);
            Map(x => x.Insurance, 11);
            Map(x => x.Order, 12);
        }
    }
}