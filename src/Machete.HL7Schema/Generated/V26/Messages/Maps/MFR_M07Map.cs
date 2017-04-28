// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFR_M07 (MessageMap) - 
    /// </summary>
    public class MFR_M07Map :
        HL7TemplateMap<MFR_M07>
    {
        public MFR_M07Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.MSA, 2, x => x.Required = true);
            Map(x => x.ERR, 3);
            Map(x => x.QAK, 4);
            Map(x => x.QRD, 5, x => x.Required = true);
            Map(x => x.QRF, 6);
            Map(x => x.MFI, 7, x => x.Required = true);
            Map(x => x.MfQuery, 8, x => x.Required = true);
            Map(x => x.DSC, 9);
        }
    }
}