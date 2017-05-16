// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPT_PCL_PATHWAY (GroupMap) - 
    /// </summary>
    public class PPT_PCL_PATHWAYMap :
        HL7LayoutMap<PPT_PCL_PATHWAY>
    {
        public PPT_PCL_PATHWAYMap()
        {
            Segment(x => x.PTH, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.VAR, 2);
            Layout(x => x.PathwayRole, 3);
            Layout(x => x.Goal, 4);
        }
    }
}