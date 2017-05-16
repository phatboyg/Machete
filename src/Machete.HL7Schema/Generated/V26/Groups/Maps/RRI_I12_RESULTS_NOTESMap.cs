// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRI_I12_RESULTS_NOTES (GroupMap) - 
    /// </summary>
    public class RRI_I12_RESULTS_NOTESMap :
        HL7LayoutMap<RRI_I12_RESULTS_NOTES>
    {
        public RRI_I12_RESULTS_NOTESMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}