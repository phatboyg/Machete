// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OSR_Q06_RESPONSE (GroupMap) - 
    /// </summary>
    public class OSR_Q06_RESPONSEMap :
        HL7V26LayoutMap<OSR_Q06_RESPONSE>
    {
        public OSR_Q06_RESPONSEMap()
        {
            Layout(x => x.Patient, 0);
            Layout(x => x.Order, 1, x => x.Required = true);
        }
    }
}