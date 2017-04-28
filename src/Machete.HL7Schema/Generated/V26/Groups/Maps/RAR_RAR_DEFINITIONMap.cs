// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAR_RAR_DEFINITION (GroupMap) - 
    /// </summary>
    public class RAR_RAR_DEFINITIONMap :
        HL7TemplateMap<RAR_RAR_DEFINITION>
    {
        public RAR_RAR_DEFINITIONMap()
        {
            Map(x => x.QRD, 0, x => x.Required = true);
            Map(x => x.QRF, 1);
            Map(x => x.Patient, 2);
            Map(x => x.Order, 3, x => x.Required = true);
        }
    }
}