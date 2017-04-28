// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RCL_I06 (MessageMap) - 
    /// </summary>
    public class RCL_I06Map :
        HL7TemplateMap<RCL_I06>
    {
        public RCL_I06Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.QRD, 4, x => x.Required = true);
            Map(x => x.QRF, 5);
            Map(x => x.Provider, 6, x => x.Required = true);
            Map(x => x.PID, 7, x => x.Required = true);
            Map(x => x.DG1, 8);
            Map(x => x.DRG, 9);
            Map(x => x.AL1, 10);
            Map(x => x.NTE, 11);
            Map(x => x.DSP, 12);
            Map(x => x.DSC, 13);
        }
    }
}