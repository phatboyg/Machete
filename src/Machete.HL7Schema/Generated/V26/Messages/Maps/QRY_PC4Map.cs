// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QRY_PC4 (MessageMap) - 
    /// </summary>
    public class QRY_PC4Map :
        HL7TemplateMap<QRY_PC4>
    {
        public QRY_PC4Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.QRD, 3, x => x.Required = true);
            Map(x => x.QRF, 4);
        }
    }
}