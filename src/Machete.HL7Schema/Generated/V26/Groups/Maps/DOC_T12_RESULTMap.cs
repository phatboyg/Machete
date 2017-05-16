// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DOC_T12_RESULT (GroupMap) - 
    /// </summary>
    public class DOC_T12_RESULTMap :
        HL7LayoutMap<DOC_T12_RESULT>
    {
        public DOC_T12_RESULTMap()
        {
            Segment(x => x.EVN, 0);
            Segment(x => x.PID, 1, x => x.Required = true);
            Segment(x => x.PV1, 2, x => x.Required = true);
            Segment(x => x.TXA, 3, x => x.Required = true);
            Segment(x => x.OBX, 4);
        }
    }
}