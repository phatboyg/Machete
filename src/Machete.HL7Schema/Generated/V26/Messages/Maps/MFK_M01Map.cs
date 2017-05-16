// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFK_M01 (MessageMap) - 
    /// </summary>
    public class MFK_M01Map :
        HL7LayoutMap<MFK_M01>
    {
        public MFK_M01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segment(x => x.ERR, 4);
            Segment(x => x.MFI, 5, x => x.Required = true);
            Segment(x => x.MFA, 6);
        }
    }
}