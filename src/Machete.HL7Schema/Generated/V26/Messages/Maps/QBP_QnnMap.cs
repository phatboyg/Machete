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
        HL7V26LayoutMap<QBP_Qnn>
    {
        public QBP_QnnMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.QPD, 3, x => x.Required = true);
            Segment(x => x.RDF, 4);
            Segment(x => x.RCP, 5, x => x.Required = true);
            Segment(x => x.DSC, 6);
            Segment(x => x.MSH2, 7, x => x.Required = true);
            Segment(x => x.SFT2, 8);
            Segment(x => x.UAC2, 9);
            Segment(x => x.MSA, 10, x => x.Required = true);
            Segment(x => x.ERR, 11);
            Segment(x => x.QAK, 12, x => x.Required = true);
            Segment(x => x.QPD2, 13, x => x.Required = true);
            Segment(x => x.Hxx, 14, x => x.Required = true);
            Segment(x => x.DSC2, 15);
        }
    }
}