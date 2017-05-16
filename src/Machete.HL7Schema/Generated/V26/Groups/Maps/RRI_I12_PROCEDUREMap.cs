// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRI_I12_PROCEDURE (GroupMap) - 
    /// </summary>
    public class RRI_I12_PROCEDUREMap :
        HL7LayoutMap<RRI_I12_PROCEDURE>
    {
        public RRI_I12_PROCEDUREMap()
        {
            Segment(x => x.PR1, 0, x => x.Required = true);
            Layout(x => x.AuthorizationContact, 1);
        }
    }
}