// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXX_V02_PATIENT (GroupMap) - 
    /// </summary>
    public class VXX_V02_PATIENTMap :
        HL7V26LayoutMap<VXX_V02_PATIENT>
    {
        public VXX_V02_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.NK1, 1);
        }
    }
}