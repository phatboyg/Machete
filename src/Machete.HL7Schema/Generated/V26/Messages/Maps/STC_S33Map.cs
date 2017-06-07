// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// STC_S33 (MessageMap) - 
    /// </summary>
    public class STC_S33Map :
        HL7V26LayoutMap<STC_S33>
    {
        public STC_S33Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.SCP, 3, x => x.Required = true);
        }
    }
}