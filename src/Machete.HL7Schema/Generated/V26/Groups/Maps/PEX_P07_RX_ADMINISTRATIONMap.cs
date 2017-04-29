// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEX_P07_RX_ADMINISTRATION (GroupMap) - 
    /// </summary>
    public class PEX_P07_RX_ADMINISTRATIONMap :
        HL7TemplateMap<PEX_P07_RX_ADMINISTRATION>
    {
        public PEX_P07_RX_ADMINISTRATIONMap()
        {
            Segment(x => x.RXA, 0, x => x.Required = true);
            Segment(x => x.RXR, 1);
        }
    }
}