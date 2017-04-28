// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPU_R25_SPECIMEN (GroupMap) - 
    /// </summary>
    public class OPU_R25_SPECIMENMap :
        HL7TemplateMap<OPU_R25_SPECIMEN>
    {
        public OPU_R25_SPECIMENMap()
        {
            Map(x => x.SPM, 0, x => x.Required = true);
            Map(x => x.SpecimenObservation, 1);
            Map(x => x.Container, 2);
            Map(x => x.Order, 3, x => x.Required = true);
        }
    }
}