// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SUR_P09_FACILITY (GroupMap) - 
    /// </summary>
    public class SUR_P09_FACILITYMap :
        HL7V26LayoutMap<SUR_P09_FACILITY>
    {
        public SUR_P09_FACILITYMap()
        {
            Segment(x => x.FAC, 0, x => x.Required = true);
            Layout(x => x.Product, 1, x => x.Required = true);
            Segment(x => x.PSH, 2, x => x.Required = true);
            Layout(x => x.FacilityDetail, 3, x => x.Required = true);
        }
    }
}