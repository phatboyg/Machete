// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRA_O18_ADMINISTRATION (GroupMap) - 
    /// </summary>
    public class RRA_O18_ADMINISTRATIONMap :
        HL7TemplateMap<RRA_O18_ADMINISTRATION>
    {
        public RRA_O18_ADMINISTRATIONMap()
        {
            Segments(x => x.RXA, 0, x => x.Required = true);
            Segment(x => x.RXR, 1, x => x.Required = true);
        }
    }
}