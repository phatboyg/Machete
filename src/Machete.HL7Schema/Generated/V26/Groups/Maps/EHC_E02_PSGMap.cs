// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E02_PSG (GroupMap) - 
    /// </summary>
    public class EHC_E02_PSGMap :
        HL7TemplateMap<EHC_E02_PSG>
    {
        public EHC_E02_PSGMap()
        {
            Map(x => x.PSG, 0, x => x.Required = true);
            Map(x => x.PSL, 1);
        }
    }
}