// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E20_DIAGNOSIS (GroupMap) - 
    /// </summary>
    public class EHC_E20_DIAGNOSISMap :
        HL7LayoutMap<EHC_E20_DIAGNOSIS>
    {
        public EHC_E20_DIAGNOSISMap()
        {
            Segment(x => x.DG1, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}