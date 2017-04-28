// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPG_PCG_PROBLEM_OBSERVATION (GroupMap) - 
    /// </summary>
    public class PPG_PCG_PROBLEM_OBSERVATIONMap :
        HL7TemplateMap<PPG_PCG_PROBLEM_OBSERVATION>
    {
        public PPG_PCG_PROBLEM_OBSERVATIONMap()
        {
            Map(x => x.OBX, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}