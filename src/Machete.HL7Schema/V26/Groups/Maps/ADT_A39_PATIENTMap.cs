// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A39_PATIENT (GroupMap) - 
    /// </summary>
    public class ADT_A39_PATIENTMap :
        HL7V26LayoutMap<ADT_A39_PATIENT>
    {
        public ADT_A39_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Segment(x => x.MRG, 2, x => x.Required = true);
            Segment(x => x.PV1, 3);
        }
    }
}