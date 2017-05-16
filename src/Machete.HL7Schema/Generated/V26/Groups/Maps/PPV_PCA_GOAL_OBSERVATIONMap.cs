// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPV_PCA_GOAL_OBSERVATION (GroupMap) - 
    /// </summary>
    public class PPV_PCA_GOAL_OBSERVATIONMap :
        HL7LayoutMap<PPV_PCA_GOAL_OBSERVATION>
    {
        public PPV_PCA_GOAL_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}