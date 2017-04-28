// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z88_ALLERGY (GroupMap) - 
    /// </summary>
    public class RSP_Z88_ALLERGYMap :
        HL7TemplateMap<RSP_Z88_ALLERGY>
    {
        public RSP_Z88_ALLERGYMap()
        {
            Map(x => x.AL1, 0, x => x.Required = true);
            Map(x => x.Visit, 1);
        }
    }
}