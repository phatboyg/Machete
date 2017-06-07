// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DOC_T12 (MessageMap) - 
    /// </summary>
    public class DOC_T12Map :
        HL7V26LayoutMap<DOC_T12>
    {
        public DOC_T12Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segment(x => x.ERR, 2);
            Segment(x => x.QAK, 3);
            Segment(x => x.QRD, 4, x => x.Required = true);
            Layout(x => x.Result, 5, x => x.Required = true);
            Segment(x => x.DSC, 6);
        }
    }
}