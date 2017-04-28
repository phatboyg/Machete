// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// REF_I12_RESULTS_NOTES (GroupMap) - 
    /// </summary>
    public class REF_I12_RESULTS_NOTESMap :
        HL7TemplateMap<REF_I12_RESULTS_NOTES>
    {
        public REF_I12_RESULTS_NOTESMap()
        {
            Map(x => x.OBX, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}