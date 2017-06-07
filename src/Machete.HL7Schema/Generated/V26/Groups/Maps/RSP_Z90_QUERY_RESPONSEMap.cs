// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z90_QUERY_RESPONSE (GroupMap) - 
    /// </summary>
    public class RSP_Z90_QUERY_RESPONSEMap :
        HL7V26LayoutMap<RSP_Z90_QUERY_RESPONSE>
    {
        public RSP_Z90_QUERY_RESPONSEMap()
        {
            Layout(x => x.Patient, 0);
            Layout(x => x.CommonOrder, 1, x => x.Required = true);
            Layout(x => x.Specimen, 2);
        }
    }
}