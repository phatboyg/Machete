// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QRY_Q02 (MessageMap) - 
    /// </summary>
    public class QRY_Q02Map :
        HL7TemplateMap<QRY_Q02>
    {
        public QRY_Q02Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.QRD, 3, x => x.Required = true);
            Map(x => x.QRF, 4);
            Map(x => x.DSC, 5);
        }
    }
}