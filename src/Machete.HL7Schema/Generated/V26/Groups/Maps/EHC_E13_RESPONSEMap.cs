// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E13_RESPONSE (GroupMap) - 
    /// </summary>
    public class EHC_E13_RESPONSEMap :
        HL7TemplateMap<EHC_E13_RESPONSE>
    {
        public EHC_E13_RESPONSEMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.TXA, 2);
        }
    }
}