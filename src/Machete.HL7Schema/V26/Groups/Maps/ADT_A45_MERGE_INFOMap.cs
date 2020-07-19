// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A45_MERGE_INFO (GroupMap) - 
    /// </summary>
    public class ADT_A45_MERGE_INFOMap :
        HL7V26LayoutMap<ADT_A45_MERGE_INFO>
    {
        public ADT_A45_MERGE_INFOMap()
        {
            Segment(x => x.MRG, 0, x => x.Required = true);
            Segment(x => x.PV1, 1, x => x.Required = true);
        }
    }
}