// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EAR_U08_COMMAND_RESPONSE (GroupMap) - 
    /// </summary>
    public class EAR_U08_COMMAND_RESPONSEMap :
        HL7V26LayoutMap<EAR_U08_COMMAND_RESPONSE>
    {
        public EAR_U08_COMMAND_RESPONSEMap()
        {
            Segment(x => x.ECD, 0, x => x.Required = true);
            Layout(x => x.SpecimenContainer, 1);
            Segment(x => x.ECR, 2, x => x.Required = true);
        }
    }
}