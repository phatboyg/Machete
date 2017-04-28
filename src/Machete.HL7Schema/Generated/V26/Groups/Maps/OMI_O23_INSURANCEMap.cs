// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMI_O23_INSURANCE (GroupMap) - 
    /// </summary>
    public class OMI_O23_INSURANCEMap :
        HL7TemplateMap<OMI_O23_INSURANCE>
    {
        public OMI_O23_INSURANCEMap()
        {
            Map(x => x.IN1, 0, x => x.Required = true);
            Map(x => x.IN2, 1);
            Map(x => x.IN3, 2);
        }
    }
}