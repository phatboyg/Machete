// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QBP_Qnn (MessageMap) - 
    /// </summary>
    public class QBP_QnnMap :
        HL7TemplateMap<QBP_Qnn>
    {
        public QBP_QnnMap()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.QPD, 3, x => x.Required = true);
            Map(x => x.RDF, 4);
            Map(x => x.RCP, 5, x => x.Required = true);
            Map(x => x.DSC, 6);
            Map(x => x.MSH2, 7, x => x.Required = true);
            Map(x => x.SFT2, 8);
            Map(x => x.UAC2, 9);
            Map(x => x.MSA, 10, x => x.Required = true);
            Map(x => x.ERR, 11);
            Map(x => x.QAK, 12, x => x.Required = true);
            Map(x => x.QPD2, 13, x => x.Required = true);
            Map(x => x.Hxx, 14, x => x.Required = true);
            Map(x => x.DSC2, 15);
        }
    }
}