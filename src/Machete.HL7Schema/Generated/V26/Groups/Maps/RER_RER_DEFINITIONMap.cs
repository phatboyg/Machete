// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RER_RER_DEFINITION (GroupMap) - 
    /// </summary>
    public class RER_RER_DEFINITIONMap :
        HL7TemplateMap<RER_RER_DEFINITION>
    {
        public RER_RER_DEFINITIONMap()
        {
            Segment(x => x.QRD, 0, x => x.Required = true);
            Segment(x => x.QRF, 1);
            Group(x => x.Patient, 2);
            Groups(x => x.Order, 3, x => x.Required = true);
        }
    }
}