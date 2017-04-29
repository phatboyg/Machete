// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPT_PCL_PROBLEM (GroupMap) - 
    /// </summary>
    public class PPT_PCL_PROBLEMMap :
        HL7TemplateMap<PPT_PCL_PROBLEM>
    {
        public PPT_PCL_PROBLEMMap()
        {
            Segment(x => x.PRB, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.VAR, 2);
            Groups(x => x.ProblemRole, 3);
            Groups(x => x.ProblemObservation, 4);
        }
    }
}