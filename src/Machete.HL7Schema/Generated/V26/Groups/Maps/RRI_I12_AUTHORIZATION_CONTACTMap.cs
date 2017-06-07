// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRI_I12_AUTHORIZATION_CONTACT (GroupMap) - 
    /// </summary>
    public class RRI_I12_AUTHORIZATION_CONTACTMap :
        HL7V26LayoutMap<RRI_I12_AUTHORIZATION_CONTACT>
    {
        public RRI_I12_AUTHORIZATION_CONTACTMap()
        {
            Segment(x => x.AUT, 0, x => x.Required = true);
            Segment(x => x.CTD, 1);
        }
    }
}