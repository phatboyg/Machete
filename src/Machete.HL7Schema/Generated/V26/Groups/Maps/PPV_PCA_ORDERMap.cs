// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPV_PCA_ORDER (GroupMap) - 
    /// </summary>
    public class PPV_PCA_ORDERMap :
        HL7LayoutMap<PPV_PCA_ORDER>
    {
        public PPV_PCA_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.OrderDetail, 1);
        }
    }
}