// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAS_O17_COMPONENTS (GroupMap) - 
    /// </summary>
    public class RAS_O17_COMPONENTSMap :
        HL7V26LayoutMap<RAS_O17_COMPONENTS>
    {
        public RAS_O17_COMPONENTSMap()
        {
            Segment(x => x.RXC, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}