// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQA_I08_VISIT (GroupMap) - 
    /// </summary>
    public class RQA_I08_VISITMap :
        HL7V26LayoutMap<RQA_I08_VISIT>
    {
        public RQA_I08_VISITMap()
        {
            Segment(x => x.PV1, 0, x => x.Required = true);
            Segment(x => x.PV2, 1);
        }
    }
}