// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXX_V02 (MessageMap) - 
    /// </summary>
    public class VXX_V02Map :
        HL7TemplateMap<VXX_V02>
    {
        public VXX_V02Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.MSA, 1, x => x.Required = true);
            Map(x => x.SFT, 2);
            Map(x => x.UAC, 3);
            Map(x => x.QRD, 4, x => x.Required = true);
            Map(x => x.QRF, 5);
            Map(x => x.Patient, 6, x => x.Required = true);
        }
    }
}