// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// REF_I12_PROVIDER_CONTACT (GroupMap) - 
    /// </summary>
    public class REF_I12_PROVIDER_CONTACTMap :
        HL7V26LayoutMap<REF_I12_PROVIDER_CONTACT>
    {
        public REF_I12_PROVIDER_CONTACTMap()
        {
            Segment(x => x.PRD, 0, x => x.Required = true);
            Segment(x => x.CTD, 1);
        }
    }
}