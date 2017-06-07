// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PMU_B07_CERTIFICATE (GroupMap) - 
    /// </summary>
    public class PMU_B07_CERTIFICATEMap :
        HL7V26LayoutMap<PMU_B07_CERTIFICATE>
    {
        public PMU_B07_CERTIFICATEMap()
        {
            Segment(x => x.CER, 0, x => x.Required = true);
            Segment(x => x.ROL, 1);
        }
    }
}