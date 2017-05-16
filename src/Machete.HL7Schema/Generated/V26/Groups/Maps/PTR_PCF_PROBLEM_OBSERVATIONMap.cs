// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PTR_PCF_PROBLEM_OBSERVATION (GroupMap) - 
    /// </summary>
    public class PTR_PCF_PROBLEM_OBSERVATIONMap :
        HL7LayoutMap<PTR_PCF_PROBLEM_OBSERVATION>
    {
        public PTR_PCF_PROBLEM_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}