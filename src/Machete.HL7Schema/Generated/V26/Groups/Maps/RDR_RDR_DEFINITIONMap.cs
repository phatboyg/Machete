// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDR_RDR_DEFINITION (GroupMap) - 
    /// </summary>
    public class RDR_RDR_DEFINITIONMap :
        HL7TemplateMap<RDR_RDR_DEFINITION>
    {
        public RDR_RDR_DEFINITIONMap()
        {
            Map(x => x.QRD, 0, x => x.Required = true);
            Map(x => x.QRF, 1);
            Map(x => x.Patient, 2);
            Map(x => x.Order, 3, x => x.Required = true);
            Map(x => x.RXR, 4, x => x.Required = true);
        }
    }
}