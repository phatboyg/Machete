// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_SPECIMEN (GroupMap) - 
    /// </summary>
    public class OPL_O37_SPECIMENMap :
        HL7TemplateMap<OPL_O37_SPECIMEN>
    {
        public OPL_O37_SPECIMENMap()
        {
            Map(x => x.SPM, 0, x => x.Required = true);
            Map(x => x.OBX, 1);
            Map(x => x.Container, 2);
            Map(x => x.ObservationRequest, 3, x => x.Required = true);
        }
    }
}