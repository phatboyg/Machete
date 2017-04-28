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
            Map(x => x.PRB, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.VAR, 2);
            Map(x => x.ProblemRole, 3);
            Map(x => x.ProblemObservation, 4);
        }
    }
}